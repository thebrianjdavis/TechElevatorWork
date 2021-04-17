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

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }
        [HttpGet("/auctions")]
        public List<Auction> ListAllAuctions(string title_like = "", double currentBid_lte = 0)
        {
            List<Auction> auctions = new List<Auction>();
            if (title_like != "" && currentBid_lte != 0)
            {
                auctions = dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (title_like != "")
            {
                auctions = dao.SearchByTitle(title_like);
            }
            else if (currentBid_lte != 0)
            {
                auctions = dao.SearchByPrice(currentBid_lte);
            }
            else
            {
                auctions = dao.List();
            }
            return auctions;
        }
        public List<Auction> SearchAuctionByTitle(string title_like = "")
        {
            return dao.SearchByTitle(title_like);
        }
        [HttpGet("/auctions/{id}")]
        public Auction Get(int id)
        {
            return dao.Get(id);
        }
        [HttpPost("/auctions")]
        public Auction CreateNewAuction(Auction newAuction)
        {
            return dao.Create(newAuction);
        }
    }
}
