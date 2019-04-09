using Kweler.Data.Repositories.Songs;
using Kweler.Domain.Services.Songs;
using Kweler.Presentation.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using System.Linq;
using System.Threading.Tasks;
using Kweler.Domain.Models.Songs;

using Kweler.Presentation.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Kweler.Tests.Controllers
{
    public class SongsControllerTest
    {
       
        private ISongsService _service;
        private SongsController _songsController;

        public SongsControllerTest()
        {
            //this._repo = new SongsRepository();
            this._service = new SongsServiceFake();
            this._songsController = new SongsController(_service);
        }

        [Fact]
        public void Get_Ok() {
            var result = _songsController.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Returns_Songs() {
            var result = _songsController.Get() as OkObjectResult;
            var songs = result.Value as SongsViewModel;
            Assert.Equal(3, songs.Songs.Count);
        }

        [Fact]
        public void Get_ById_ReturnsNotFound_When_Id_Is_Invalid() {
            var result = _songsController.Get(Guid.NewGuid());
            Assert.IsType<NotFoundResult>(result);

        }

        [Fact]
        public void Get_ById_ReturnsOk_When_Id_Is_Valid() {
            var result = _songsController.Get(new Guid("25A5C147-7F60-421C-8213-3FBCC6293A7D")) as OkObjectResult;
            
            Assert.IsType<OkObjectResult>(result);
            Assert.Matches("200", result.StatusCode.ToString());
        }

        [Fact]
        public void Post_Invalid_Song_Returns_Bad_Request() {
            Song s = new Song() { IsDeleted = true };
            _songsController.ModelState.AddModelError("Title", "required");
            var result = _songsController.Post(s);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void Post_Valid_Song_Returns_Created() {
            Song s = new Song() { Title = "Als je bang bent in het donker moet je fluiten", IsDeleted = true };
            var result = _songsController.Post(s);

            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public void Post_Valid_Song_Should_Return_New_Song() {

            var validSong = new Song() {
                Title = "Ik spring uit een vliegmachine",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            var response = _songsController.Post(validSong);
            var createdSong = (response as CreatedAtActionResult).Value as Song;

            Assert.IsType<Song>(createdSong);
            Assert.NotEqual(createdSong.Id, Guid.Empty);
        }

        [Fact]
        public void Get_Songs_From_Moq() {
            var serviceMock = new Mock<ISongsService>();
            serviceMock.Setup(x => x.GetAll()).Returns(() => new List<Song>{
                new Song(){
                    Id =new Guid("5DC85CE0-D978-4112-AC5D-9A30CE70F175"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                },
                new Song(){
                    Id =new Guid("25A5C147-7F60-421C-8213-3FBCC6293A7D"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                },
                new Song(){
                    Id =new Guid("C47F59CA-0007-4E16-93F5-93C5A5848209"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                }
            });

            var controller = new SongsController(serviceMock.Object);

            var result = _songsController.Get();
            Assert.IsType<OkObjectResult>(result);

        }


    }
}
