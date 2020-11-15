using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigations.MasterDetailDemo
{

    public class CutommersMasterDetailPageMasterMenuItem
    {
        public CutommersMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(CutommersMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}