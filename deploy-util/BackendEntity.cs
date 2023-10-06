using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deploy_util
{
    public class BackendEntity
    {
        [Required]
        public string Technology {  get; set; }
        [Required]
        public string Domain {  get; set; }
        [Required]
        public string RemoteDisk {  get; set; }
        [Required]
        public string PathToJar {  get; set; }
        [Required]
        public string PathForDeploy {  get; set; }
        [Required]
        public string Username {  get; set; }
        [Required, RegularExpression(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$)")]
        public string HostIP {  get; set; }
        public string JasyptKey {  get; set; }
        [Required]
        [Range(0, 65535)]
        public int Port {  get; set; }
        public bool ConfigureSSL {  get; set; }
        public bool ConfigureJasyptKey {  get; set; }
        public bool ConfigureNginx {  get; set; }
    }
}
