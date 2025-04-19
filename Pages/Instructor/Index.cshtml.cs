using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolAppCore.Models;

namespace SchoolAppCore.Pages.Instructor
{
    public class IndexModel : PageModel
    {
        private readonly SchoolAppCore.Models.SchoolContext _context;

        public IndexModel(SchoolAppCore.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<SchoolAppCore.Models.Instructor> Instructor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Instructor = await _context.Instructors.ToListAsync();
        }
    }
}
