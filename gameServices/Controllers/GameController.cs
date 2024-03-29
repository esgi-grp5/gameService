﻿using Microsoft.AspNetCore.Mvc;
using gameServices.Models;
using gameServices.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;


namespace gameServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase

    {
        public IGameServices gameServices { get; set; }
        public string GameName { get; private set; }

        public GameController(IGameServices GameServices)
        {
            gameServices = GameServices;
        }

        [HttpGet("searchByName/{GameName}")]
        public async Task<string> GetByName(string GameName)
        {
            var result = new HttpResponseApi();

            try
            {
                var response = await gameServices.getGameByName(GameName);
                result.resultList = new List<MyGame>();
                result.resultList.Add(response);
                result.resultCount = result.resultList.Count();
                result.Status = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                result.Status = HttpStatusCode.InternalServerError;
                result.Message = ex.Message;
            }
            return JsonSerializer.Serialize(result);
        }

        [HttpGet("searchById/{GameId}")]
        public async Task<string> GetByID(int GameId)
        {
            var result = new HttpResponseApi();

            try
            {
                var response = await gameServices.getGameById(GameId);
                result.resultId = new List<MyGameById>();
                result.resultId.Add(response);
                result.resultCount = result.resultId.Count();
                result.Status = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                result.Status = HttpStatusCode.InternalServerError;
                result.Message = ex.Message;
            }
            return JsonSerializer.Serialize(result);
        }
    }
}
