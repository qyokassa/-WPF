using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Система_учета_WPF
{
   public partial class Shelf
    {
        public int Id { get; set; }

        /// <summary>
        /// название &quot;стеллажа&quot;
        /// </summary>
        public string Title { get; set; } = null!;

        public int IdDevil { get; set; }

        public int YearBuy { get; set; }

        /// <summary>
        /// макс кол-во применений
        /// </summary>
        public int UseCount { get; set; }

        /// <summary>
        /// кол-во применений
        /// </summary>
        public int CurrentCount { get; set; }

        public virtual Worker IdDevilNavigation { get; set; } = null!;
    }
}
