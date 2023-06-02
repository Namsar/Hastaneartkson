using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimSistemi
{
    public class RandevuBilgileriSınıfı
    {
        public string Id { get; set; }
        public Poliklinik poliklinik { get; set; }
        public Hekim hekim { get; set; }
        public B_Cerrah b_Cerrah { get; set; }
        public Kalp_Damar kalp_Damar { get; set; }
        public Kardiyoloji kardiyoloji { get; set; }
        public KBB kBB { get; set; }
        public Nefroloji nefroloji { get; set; }
        public Nöroloji nöroloji { get; set; }
        public ORTOPEDİ_VE_TRAVMATOLOJİ ORTOPEDİ_vE_TRAVMATOLOJİ { get; set; }
        public Diyabet diyabet { get; set; }

        public string tarih { get; set; }
        public string saat { get; set; }

        public enum Poliklinik
        {
            BEYİN_VE_SİNİR_CERRAHİSİ, DİYABET, KALP_DAMAR_CERRAHİSİ, KARDİYOLOJİ, KBB, NEFROLOJİ, NÖROLOJİ, ORTOPEDİ_VE_TRAVMATOLOJİ
        }
        public enum Hekim
        {
            ProfDr_Abdullah_İĞCİ, ProfDr_Abdurrahman_ÖNEN, ProfDr_Adnan_SAYAR, ProfDr_Ahmet_SOYSAL,
            ProfDr_Ali_DEMİRCİ, ProfDr_Aydın_TÜRKMEN, ProfDr_Ayşe_SERTKAYA, UzmDr_Abdurrahman_YILDIRIM,
            UzmDr_Ahmet_ARPACI, OpDr_Arda_ÇINAR, OpDr_Asena_AYAR, Dr_Alper_ÖZBAŞ, Dt_Aslı_TAPAN,
            ProfDr_Esra_SAĞLAM, ProfDr_Engin_ÇAKAR, DoçDr_Ercan_TUTAK, UzmDr_Ebru_TÜRK, DoçDr_Gökhan_ERTAŞ,
            OpDr_Gönül_ÖZER, UzmPsi_Gizem_ÇÖLÜMLÜ, ProfDr_Sami_KATIRCIOĞLU, ProfDr_Sedat_ÖZKAN,
            OpDr_Melih_AYGÜN, OpDr_Miraç_TURAN, UzmFzt_Onur_KÖKSAL, UzmDyt_Merve_YÜKSEK, PedagogDr_Melda_ALANTAR, Dyt_Ezgi_MUMCU
        }
        public enum B_Cerrah // Beyin cerrahi doktorları
        {
            ProfDr_Abdullah_İĞCİ,
            ProfDr_Ali_DEMİRCİ, ProfDr_Aydın_TÜRKMEN, ProfDr_Ayşe_SERTKAYA
        }
        public enum Kalp_Damar
        {
            UzmDr_Abdurrahman_YILDIRIM,
            UzmDr_Ahmet_ARPACI, OpDr_Arda_ÇINAR, OpDr_Asena_AYAR
        }
        public enum Kardiyoloji
        {
            Dr_Alper_ÖZBAŞ, Dt_Aslı_TAPAN,
            ProfDr_Esra_SAĞLAM, ProfDr_Engin_ÇAKAR, DoçDr_Ercan_TUTAK
        }
        public enum Nefroloji
        {
            UzmDr_Ebru_TÜRK, DoçDr_Gökhan_ERTAŞ,
            OpDr_Gönül_ÖZER, UzmPsi_Gizem_ÇÖLÜMLÜ, ProfDr_Sami_KATIRCIOĞLU
        }

        public enum KBB
        {
            ProfDr_Sedat_ÖZKAN,
            OpDr_Melih_AYGÜN, OpDr_Miraç_TURAN
        }
        public enum Nöroloji
        {
            ProfDr_Abdurrahman_ÖNEN, ProfDr_Adnan_SAYAR, ProfDr_Ahmet_SOYSAL
        }
        public enum ORTOPEDİ_VE_TRAVMATOLOJİ
        {
            UzmDyt_Merve_YÜKSEK, Dyt_Ezgi_MUMCU
        }
        public enum Diyabet
        {
            PedagogDr_Melda_ALANTAR, UzmPsi_Gizem_ÇÖLÜMLÜ
        }

        public RandevuBilgileriSınıfı()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
