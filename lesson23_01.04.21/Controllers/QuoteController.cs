using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lesson23_01._04._21.Db;
using lesson23_01._04._21.Models;
using Microsoft.EntityFrameworkCore;

//дичайше извиняюсь за отсутствие вьюшек, я заливаю проект через 21мин после дэдлайна

namespace lesson23_01._04._21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        DataContext _db;
        public QuoteController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quote>>> Get()
        {
            AutoDelete();
            return await _db.Quotes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> Get(int id)
        {
            AutoDelete(); 
            var quote = await _db.Quotes.FirstOrDefaultAsync(q => q.Id == id);
            if (quote == null)
            {
                return NotFound($"Цитата {id} не найдена");
            }
            return quote;
        }

        [HttpPost]
        public async Task<ActionResult<Quote>> Post(Quote quote)
        {
            AutoDelete(); 
            quote.InsertDate = DateTime.Now; 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Quotes.Add(quote);
            if (await _db.SaveChangesAsync() > 0)
            {
                return Ok("Добавлено");
            }
            return BadRequest("Ошибка добавления");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Quote>> Put(int id, Quote quote)
        {
            AutoDelete(); 
            var tempQuote = await _db.Quotes.FindAsync(id);
            if ( tempQuote == null)
            {
                return NotFound($"Цитата {id} не найдена");
            }
            tempQuote.Author = quote.Author ?? tempQuote.Author;
            tempQuote.Text = quote.Text ?? tempQuote.Text;
            tempQuote.InsertDate = DateTime.Now; 

            if (await _db.SaveChangesAsync() > 0)
            {
                return Ok("Обновлено");
            }
            return BadRequest("Ошибка обновления");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var quote = await _db.Quotes.FindAsync(id);
            if (quote == null)
            {
                return NotFound($"Цитата {id} не найдена");
            }
            _db.Remove(quote);
            if (await _db.SaveChangesAsync() > 0)
            {
                return Ok($"Цитата {id} удалена");
            }
            return BadRequest("Ошибка удаления");
        }

        [NonAction]
        internal void AutoDelete()
        {
            var quotes = _db.Quotes.ToList();

            foreach (var quote in quotes)
            {
                if ((Math.Abs(quote.InsertDate.Month - DateTime.Now.Month) > 0
                    && quote.InsertDate.Year == DateTime.Now.Year) || Math.Abs(quote.InsertDate.Year - DateTime.Now.Year) > 0)
                {
                    _db.Quotes.Remove(quote);
                }
            }
        }
    }
}
