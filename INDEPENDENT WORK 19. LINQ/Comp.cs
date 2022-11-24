using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEPENDENT_WORK_19.LINQ
{
    /* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти,
     * объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. */
    class Comp
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string TypeProc { get; set; }
        public double RateProc { get; set; }
        public int RAM { get; set; }
        public int HardDrive { get; set; }
        public int MemoryVC { get; set; }
        public double Price { get; set; }
        public int Copies { get; set; }
    }
}
