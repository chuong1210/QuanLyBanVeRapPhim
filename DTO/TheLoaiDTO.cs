using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
        public TheLoaiDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenTheLoai = row["TenTheLoai"].ToString();
            if (row["MoTa"].ToString() != "")
                this.MoTa = row["MoTa"].ToString();
            else
                this.MoTa = "";
        }
        public TheLoaiDTO()
        {
                
        }
        public string Id { get; set; }
        public string TenTheLoai { get; set; }
        public string MoTa { get; set; }
    }

}
