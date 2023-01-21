using System;
using System.Linq;
using System.Threading.Tasks;
using Business.Service;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Familytree.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;

        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException("Id");
            }
            var data = await _cardService.Get(id);
            if (data is null)
            {
                throw new NullReferenceException("card is null");
            }

            return View(data);
        }



        [HttpPost]
        public async Task<IActionResult> Update(int id, Card card)
        {
            if (!ModelState.IsValid)
            {
                return View(card);
            }
            var data = await _cardService.Get(id);
            await _cardService.Update(id, card);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            if (!ModelState.IsValid)
            {
                return View(card);
            }
           
            await _cardService.Create(card);

            return RedirectToAction(nameof(Index));
        }










    }
}
