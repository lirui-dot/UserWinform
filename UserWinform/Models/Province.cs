using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWinform.Models
{
     class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string name { get; set; }

        public int parentid { get; set; }

        public string parentname { get; set; }

        public string areacode { get; set; }

        public string zipcode { get; set; }

        public string depth { get; set; }

    }
    [NotMapped]
     class ProvinceDetails
    {
        public int status { get; set; }
        public string msg { get; set; }
        public List<Province> result { get; set; }
    }
}
