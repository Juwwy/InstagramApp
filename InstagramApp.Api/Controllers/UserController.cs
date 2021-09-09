using AutoMapper;
using InstagramApp.DataEntity.Models;
using InstagramApp.DataTransferObject.User;
using InstagramApp.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramApp.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]/")]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IMapper mapper;

        public UserController(IGenericRepository<User> genericRepository,
            IMapper mapper)
        {
            _genericRepository = genericRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> AddUser([FromBody]PostUser model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var entity = mapper.Map<User>(model);
            var user = await _genericRepository.InsertEntity(entity);
            //generate referral code
            user.ReferralCode = "uuu";
            if (!string.IsNullOrEmpty(model.ReferralCode))
            {
                var refcode = _genericRepository.Table.FirstOrDefault(r => r.ReferralCode == model.ReferralCode);
                Referral refDigit = new Referral()
                {
                    Referrer = refcode.Id,
                    Referee = user.Id,
                   // Point = 5,
                };
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetUser()
        {
            var user = await _genericRepository.GetEntities();

            if (user == null)
                return null;

            return Ok(user);
        }

        [HttpGet]
        [Route("GetUser/{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _genericRepository.GetEntity(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await _genericRepository.GetEntity(id);

            if (user == null)
                return NotFound();

            return Ok(user);

        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateUser(PostUser model)
        {
            var entity = mapper.Map<User>(model);
            var user = await _genericRepository.UpdateEntity(entity);

            if (!ModelState.IsValid)
                return BadRequest();


            return Ok(user);

        }

        //[HttpPost]
        //[Route("Login")]
        //public async Task<IActionResult> LoginUser(string phone, string password, string fcmToken)
        //{
        //    if (phone != null && password != null && fcmToken != null)
        //    {
        //       var user = await _genericRepository.GetEntity(phone).Where(a => a.Telephone == phone && a.Password == password
        //       && a.FcmToken == fcmToken).FirstOrDefaultAsync();
        //        return user;
        //    }
        //    return null;
        //}

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> RemoveUser(string id)
        {

            var user = await _genericRepository.GetEntity(id);
            if(user != null)
                await _genericRepository.DeleteEntity(user);

            return NoContent();
        }
    }
}
