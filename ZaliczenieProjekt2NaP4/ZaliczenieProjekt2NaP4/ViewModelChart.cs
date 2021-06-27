using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProjekt2NaP4
{
   public  class ViewModelChart
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        public List<ChartMembers> Data { get; }
        public ViewModelChart()
        {
            var collection = _db.members.GroupBy(x => x.course, (category, member) =>
             new ChartMembers
             {
                 Course = category,
                 NumberOfMembers = member.Count()
             }
            );
            Data = new List<ChartMembers>(collection);
           
        }
    }
}
