using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction createdAuction = dao.Create(auction);
            return Created($"/reservations/{createdAuction.Id}", createdAuction);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(int id, Auction auctionToUpdate)
        {
            Auction oldAuction = dao.Get(id);
            if (oldAuction == null)
            {
                return NotFound("Reservation Not Found");
            }
            else
            {
                return Ok(dao.Update(id, auctionToUpdate));
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteReservation(int id)
        {
            Auction existingAuction = dao.Get(id);
            if (existingAuction == null)
            {
                return NotFound("Reservation Not Found");
            }
            else
            {
                bool deleted = dao.Delete(id);
                if (deleted)
                {
                    return NoContent();
                }
                else
                {
                    return StatusCode(500, "There was an error with the server - please call Joe Riggs for assistance and refuse to speak to anyone else...");
                }
            }
        }
    }
}
