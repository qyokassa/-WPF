using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Система_учета_WPF
{
    public partial class Worker
    {
        public int Id { get; set; }

        /// <summary>
        /// погоняло
        /// </summary>
        public string Nick { get; set; } = null!;

        /// <summary>
        /// кол-во душ
        /// </summary>
        public int Rank { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Shelf> Racks { get; set; } = new List<Shelf>();
    }
}
