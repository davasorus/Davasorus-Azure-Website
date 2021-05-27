using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using StreamWebPage.Models;

namespace WebAPI.Controllers
{
    //[Authorize]
    [Route("api/webapi")]
    [ApiController]
    public class AppPubsController : ControllerBase
    {
        private readonly IWebAPIRepo _WebAPIRepo;
        private readonly IMapper _mapper;

        public AppPubsController(IWebAPIRepo webAPIRepo, IMapper mapper)
        {
            _WebAPIRepo = webAPIRepo;
            _mapper = mapper;
        }

        //GET api/webapi
        [HttpGet]
        public ActionResult<IEnumerable<AppPub>> GetAllApps()
        {
            var AppItems = _WebAPIRepo.GetAllApps();
            return Ok(AppItems);
        }

        //GET api/webapi/ID
        [HttpGet("{id}", Name = "GetAppPubByID")]
        public ActionResult<AppPubReadDTO> GetAppPubByID(int ID)
        {
            var AppItemID = _WebAPIRepo.GetAppPubByID(ID);
            if (AppItemID != null)
            {
                return Ok(_mapper.Map<AppPubReadDTO>(AppItemID));
            }
            return NotFound();
        }

        //POST api/webapi
        [HttpPost]
        public ActionResult<AppPubReadDTO> CreateApp(AppPubCreateDTO appPubCreateDTO)
        {
            var AppModel = _mapper.Map<AppPub>(appPubCreateDTO);
            _WebAPIRepo.CreatApp(AppModel);
            _WebAPIRepo.SaveChanges();

            var AppPubReadDTO = _mapper.Map<AppPubReadDTO>(AppModel);

            return CreatedAtRoute(nameof(GetAppPubByID), new { Id = AppPubReadDTO.Id }, AppPubReadDTO);
        }

        //PUT api/webapi/ID
        [HttpPut("{id}")]
        public ActionResult UpdateApp(int ID, AppPubUpdateDTO appPubUpdateDTO)
        {
            var AppModelFromRepo = _WebAPIRepo.GetAppPubByID(ID);

            if (AppModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(appPubUpdateDTO, AppModelFromRepo);

            _WebAPIRepo.UpdateApp(AppModelFromRepo);

            _WebAPIRepo.SaveChanges();

            return NoContent();
        }

        //PATCH api/webapi/ID
        [HttpPatch("{id}")]
        public ActionResult PartialUpdateApp(int ID, JsonPatchDocument<AppPubUpdateDTO> patchDoc)
        {
            var AppModelFromRepo = _WebAPIRepo.GetAppPubByID(ID);

            if (AppModelFromRepo == null)
            {
                return NotFound();
            }
            var AppToPatch = _mapper.Map<AppPubUpdateDTO>(AppModelFromRepo);

            patchDoc.ApplyTo(AppToPatch, ModelState);
            if (TryValidateModel(AppToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(AppToPatch, AppModelFromRepo);

            _WebAPIRepo.UpdateApp(AppModelFromRepo);

            _WebAPIRepo.SaveChanges();

            return NoContent();
        }

        //DELETE api/webapi/id
        [HttpDelete("{id}")]
        public ActionResult DeleteApp(int ID)
        {
            var AppModelFromRepo = _WebAPIRepo.GetAppPubByID(ID);

            if (AppModelFromRepo == null)
            {
                return NotFound();
            }
            _WebAPIRepo.DeleteApp(AppModelFromRepo);

            return NoContent();
        }
    }
}