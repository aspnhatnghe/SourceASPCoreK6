using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShopK6.Models;

namespace MyShopK6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiApiController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoaiApiController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/LoaiApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loai>>> GetLoais()
        {
            return await _context.Loais.ToListAsync();
        }

        // GET: api/LoaiApi/Search/bia
        [HttpGet("Search/{keyword}")]
        public IActionResult Search(string keyword)
        {
            return this.Ok(_context.Loais.Where(p => p.TenLoai.Contains(keyword)).ToList());
        }

        // GET: api/LoaiApi/Search
        //Body: keyword = bia
        [HttpGet("SearchHangHoa")]
        public IActionResult SearchHangHoa(string keyword)
        {
            return this.Ok(_context.HangHoas.Where(p => p.TenHh.Contains(keyword)).ToList());
        }

        // GET: api/LoaiApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loai>> GetLoai(int id)
        {
            var loai = await _context.Loais.FindAsync(id);

            if (loai == null)
            {
                return NotFound();
            }

            return loai;
        }

        // PUT: api/LoaiApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoai(int id, [FromBody] Loai loai)
        {
            if (id != loai.MaLoai)
            {
                return BadRequest();
            }

            _context.Entry(loai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LoaiApi
        [HttpPost]
        public async Task<ActionResult<Loai>> PostLoai([FromBody] Loai loai)
        {
            _context.Loais.Add(loai);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoai", new { id = loai.MaLoai }, loai);
        }

        // DELETE: api/LoaiApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Loai>> DeleteLoai(int id)
        {
            var loai = await _context.Loais.FindAsync(id);
            if (loai == null)
            {
                return NotFound();
            }

            _context.Loais.Remove(loai);
            await _context.SaveChangesAsync();

            return loai;
        }

        private bool LoaiExists(int id)
        {
            return _context.Loais.Any(e => e.MaLoai == id);
        }
    }
}
