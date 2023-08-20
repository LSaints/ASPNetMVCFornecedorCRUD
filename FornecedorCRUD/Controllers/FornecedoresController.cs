using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FornecedorCRUD.Data;
using FornecedorCRUD.Models;

namespace FornecedorCRUD.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly FornecedorCRUDContext _context;
        public FornecedoresController(FornecedorCRUDContext context)
        {
            _context = context;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            var fornecedor = from m in _context.fornecedores
                             select m;
            return View(fornecedor);
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CNPJ,Especialidade,CEP,Endereco")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CNPJ,Especialidade,CEP,Endereco")] Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.fornecedores == null)
            {
                return Problem("Entity set 'FornecedorCRUDContext.fornecedores'  is null.");
            }
            var fornecedor = await _context.fornecedores.FindAsync(id);
            if (fornecedor != null)
            {
                _context.fornecedores.Remove(fornecedor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(int id)
        {
          return (_context.fornecedores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
