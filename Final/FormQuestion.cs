using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    
    public partial class FormQuestion : Form
    {
        List<MyQuestion> questionList = new List<MyQuestion>();
        private Stack<MyAnswer> myAnswers = new Stack<MyAnswer>();
        private Dictionary<String, String> description = new Dictionary<string, string>();
        private Dictionary<String, String> image = new Dictionary<string, string>();
        private Dictionary<String, String> link = new Dictionary<string, string>();
        private int currentQuestion = -1;
        private List<String> key = new List<string>()
        {
            "label", "class", "brand", "brand", "price", "price", "ram", "ram", "cpu", "hardware", "diskspace", "inch", "graphic"
        };
        private MyProlog prolog;
        private const String prologFilePath = @"..\..\Laptop.pl";

        private void BuildDescription()
        {
            description.Add("ACERAPIREA3155434U1", "Name: ACER APIRE A315 54 34U1 \r\n Brand: Acer \r\n Price: 9, 890, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE3A31554K37B0", "Name: ACER ASPIRE 3 A315 54K 37B0 \r\n Brand: Acer \r\n Price: 10, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE3A31523R8BA", "Name: ACER ASPIRE 3 A315 - 23 - R8BA \r\n Brand: Acer \r\n Price: 10, 090, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ACERASPIRE3A3155457PJ", "Name: ACER ASPIRE 3 A315 - 54 - 57PJ \r\n Brand: Acer \r\n Price: 11, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE5A51453346U", "Name: ACER ASPIRE 5 A514 53 346U \r\n Brand: Acer \r\n Price: 14, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE5A5145350P9", "Name: ACER ASPIRE 5 A514 53 50P9 \r\n Brand: Acer \r\n Price: 16, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE5A514533821", "Name: ACER ASPIRE 5 A514 - 53 - 3821 \r\n Brand: Acer \r\n Price: 13, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE5A51554G56JG", "Name: ACER ASPIRE 5 A515 54G 56JG \r\n Brand: Acer \r\n Price: 18, 690, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ACERASPIREA31542R4XD", "Name: ACER ASPIRE A315 42 R4XD \r\n Brand: Acer \r\n Price: 13, 290, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ACERASPIREA31554368N", "Name: ACER ASPIRE A315 54 368N \r\n Brand: Acer \r\n Price: 12, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIREA51451525E", "Name: ACER ASPIRE A514 - 51 - 525E \r\n Brand: Acer \r\n Price: 13, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ACERASPIREA5155436H3", "Name: ACER ASPIRE A515 - 54 - 36H3 \r\n Brand: Acer \r\n Price: 11, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIREE547650SZ", "Name: ACER ASPIRE E5 - 476 - 50SZ \r\n Brand: Acer \r\n Price: 12, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERASPIREE5576G88EP", "Name: ACER ASPIRE E5 - 576G - 88EP \r\n Brand: Acer \r\n Price: 16, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i7 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ACERASPRIREA5155350ZD", "Name: ACER ASPRIRE A515 - 53 - 50ZD \r\n Brand: Acer \r\n Price: 11, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERNITRO5AN51543R65L", "Name: ACER NITRO 5 AN515 43 R65L \r\n Brand: Acer \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 7 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ACERNITRO5AN51543R9FD", "Name: ACER NITRO 5 AN515 43 R9FD \r\n Brand: Acer \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ACERNITROAN5155459SF", "Name: ACER NITRO AN515 54 59SF \r\n Brand: Acer \r\n Price: 18, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ACERSWIFT3SF31456G78QS", "Name: ACER SWIFT 3 SF314 56G 78QS \r\n Brand: Acer \r\n Price: 19, 790, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Nvidia");
            description.Add("ACERSWIFT3SF31441R8VS", "Name: ACER SWIFT 3 SF314 - 41 - R8VS \r\n Brand: Acer \r\n Price: 14, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ACERSWIFT3SSF3145752GB", "Name: ACER SWIFT 3S SF314 57 52GB \r\n Brand: Acer \r\n Price: 18, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERSWIFTSF31456596E", "Name: ACER SWIFT SF314 - 56 - 596E \r\n Brand: Acer \r\n Price: 15, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ACERSWIFTSF31541R0DX", "Name: ACER SWIFT SF315 - 41 - R0DX \r\n Brand: Acer \r\n Price: 12, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ACERSWIFTSF3155238YQ", "Name: ACER SWIFT SF315 - 52 - 38YQ \r\n Brand: Acer \r\n Price: 10, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");

            description.Add("ASUS14D409DAEK151T", "Name: ASUS 14 D409DA - EK151T \r\n Brand: Asus \r\n Price: 9, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSA412FAEK734T", "Name: ASUS A412FA - EK734T \r\n Brand: Asus \r\n Price: 16, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSA412FAEK740T", "Name: ASUS A412FA - EK740T \r\n Brand: Asus \r\n Price: 16, 940, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSA512DAEJ406T", "Name: ASUS A512DA - EJ406T \r\n Brand: Asus \r\n Price: 14, 790, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ASUSA512FAEJ837T", "Name: ASUS A512FA - EJ837T \r\n Brand: Asus \r\n Price: 12, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSA512FLEJ165T", "Name: ASUS A512FL - EJ165T \r\n Brand: Asus \r\n Price: 19, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSA512FLEJ163T", "Name: ASUS A512FL - EJ163T \r\n Brand: Asus \r\n Price: 16, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSD570DDE4027T", "Name: ASUS D570DD - E4027T \r\n Brand: Asus \r\n Price: 15, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSD570DDE4028T", "Name: ASUS D570DD - E4028T \r\n Brand: Asus \r\n Price: 16, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSF571GTBQ532T", "Name: ASUS F571GT - BQ532T \r\n Brand: Asus \r\n Price: 17, 790, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSFX505DTAL003T", "Name: ASUS FX505DT - AL003T \r\n Brand: Asus \r\n Price: 17, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSTUFFX505DYAL060T", "Name: ASUS TUF FX505DY - AL060T \r\n Brand: Asus \r\n Price: 17, 440, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ASUSTUFFX505DYAL133T", "Name: ASUS TUF FX505DY - AL133T \r\n Brand: Asus \r\n Price: 16, 440, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ASUSTUFFX505GTAL003T", "Name: ASUS TUF FX505GT - AL003T \r\n Brand: Asus \r\n Price: 18, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKA412DAEK144T", "Name: ASUS VIVOBOOK A412DA - EK144T \r\n Brand: Asus \r\n Price: 14, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKA412DAEK160T", "Name: ASUS VIVOBOOK A412DA - EK160T \r\n Brand: Asus \r\n Price: 14, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKA412DAEK347T", "Name: ASUS VIVOBOOK A412DA - EK347T \r\n Brand: Asus \r\n Price: 10, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKA412FAEK380T", "Name: ASUS VIVOBOOK A412FA - EK380T \r\n Brand: Asus \r\n Price: 11, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKA412FAEK647T", "Name: ASUS VIVOBOOK A412FA - EK647T \r\n Brand: Asus \r\n Price: 15, 940, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKA512FAEJ099T", "Name: ASUS VIVOBOOK A512FA - EJ099T \r\n Brand: Asus \r\n Price: 11, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKA512FLEJ507T", "Name: ASUS VIVOBOOK A512FL - EJ507T \r\n Brand: Asus \r\n Price: 17, 440, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKD409DAEK109T", "Name: ASUS VIVOBOOK D409DA - EK109T \r\n Brand: Asus \r\n Price: 12, 090, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKD509DAEJ448T", "Name: ASUS VIVOBOOK D509DA - EJ448T \r\n Brand: Asus \r\n Price: 10, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKFLIPTP412FAEC122T", "Name: ASUS VIVOBOOK FLIP TP412FA - EC122T \r\n Brand: Asus \r\n Price: 17, 390, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKM413IAEK480T", "Name: ASUS VIVOBOOK M413IA - EK480T \r\n Brand: Asus \r\n Price: 15, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKS431FAEB141T", "Name: ASUS VIVOBOOK S431FA - EB141T \r\n Brand: Asus \r\n Price: 17, 190, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKTP412FAEC268T", "Name: ASUS VIVOBOOK TP412FA - EC268T \r\n Brand: Asus \r\n Price: 12, 890, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKX407UABV537T", "Name: ASUS VIVOBOOK X407UA - BV537T \r\n Brand: Asus \r\n Price: 9, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX409FAEK098T", "Name: ASUS VIVOBOOK X409FA - EK098T \r\n Brand: Asus \r\n Price: 9, 890, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX507UAEJ234T", "Name: ASUS VIVOBOOK X507UA - EJ234T \r\n Brand: Asus \r\n Price: 10, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX507UFEJ078T", "Name: ASUS VIVOBOOK X507UF - EJ078T \r\n Brand: Asus \r\n Price: 14, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX507UFEJ079T", "Name: ASUS VIVOBOOK X507UF - EJ079T \r\n Brand: Asus \r\n Price: 16, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i7 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX509FAEJ560T", "Name: ASUS VIVOBOOK X509FA - EJ560T \r\n Brand: Asus \r\n Price: 14, 590, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKX509FJEJ314T", "Name: ASUS VIVOBOOK X509FJ - EJ314T \r\n Brand: Asus \r\n Price: 15, 040, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX509JAEJ171T", "Name: ASUS VIVOBOOK X509JA - EJ171T \r\n Brand: Asus \r\n Price: 14, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKX509JPEJ014T", "Name: ASUS VIVOBOOK X509JP - EJ014T \r\n Brand: Asus \r\n Price: 15, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX509UABR011T", "Name: ASUS VIVOBOOK X509UA - BR011T \r\n Brand: Asus \r\n Price: 10, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX509UABR236T", "Name: ASUS VIVOBOOK X509UA - BR236T \r\n Brand: Asus \r\n Price: 10, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("ASUSX505ZAEJ505T", "Name: ASUS X505ZA - EJ505T \r\n Brand: Asus \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");

            description.Add("DELLINSPIRONN3476B", "Name: DELL INSPIRON N3476B \r\n Brand: Dell \r\n Price: 15, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3481", "Name: DELL INSPIRON N3481 \r\n Brand: Dell \r\n Price: 12, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3481UHD", "Name: DELL INSPIRON N3481 \r\n Brand: Dell \r\n Price: 10, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3493", "Name: DELL INSPIRON N3493 \r\n Brand: Dell \r\n Price: 10, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3493I5", "Name: DELL INSPIRON N3493 \r\n Brand: Dell \r\n Price: 15, 590, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3580", "Name: DELL INSPIRON N3580 \r\n Brand: Dell \r\n Price: 15, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3580A", "Name: DELL INSPIRON N3580A \r\n Brand: Dell \r\n Price: 11, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3581", "Name: DELL INSPIRON N3581 \r\n Brand: Dell \r\n Price: 12, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3593C", "Name: DELL INSPIRON N3593C \r\n Brand: Dell \r\n Price: 11, 090, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3593D", "Name: DELL INSPIRON N3593D \r\n Brand: Dell \r\n Price: 15, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN5584", "Name: DELL INSPIRON N5584 \r\n Brand: Dell \r\n Price: 17, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("DELLINSPIRONN5593", "Name: DELL INSPIRON N5593 \r\n Brand: Dell \r\n Price: 13, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN5593I5", "Name: DELL INSPIRON N5593 \r\n Brand: Dell \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("DELLV3590", "Name: DELL V3590 \r\n Brand: Dell \r\n Price: 16, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("DELLVOSTRO5481", "Name: DELL VOSTRO 5481 \r\n Brand: Dell \r\n Price: 18, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("DELLVOSTROV3480", "Name: DELL VOSTRO V3480 \r\n Brand: Dell \r\n Price: 14, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV3481", "Name: DELL VOSTRO V3481 \r\n Brand: Dell \r\n Price: 11, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("DELLVOSTROV3490", "Name: DELL VOSTRO V3490 \r\n Brand: Dell \r\n Price: 10, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV3590", "Name: DELL VOSTRO V3590 \r\n Brand: Dell \r\n Price: 11, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5481", "Name: DELL VOSTRO V5481 \r\n Brand: Dell \r\n Price: 17, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("DELLVOSTROV5490", "Name: DELL VOSTRO V5490 \r\n Brand: Dell \r\n Price: 14, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5581", "Name: DELL VOSTRO V5581 \r\n Brand: Dell \r\n Price: 17, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5590", "Name: DELL VOSTRO V5590 \r\n Brand: Dell \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");

            description.Add("HP14SDK0117AU", "Name: HP 14S - DK0117AU \r\n Brand: HP \r\n Price: 9, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("HP14SDK0132AU", "Name: HP 14S - DK0132AU \r\n Brand: HP \r\n Price: 13, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("HP14SDK1055AU", "Name: HP 14S - DK1055AU \r\n Brand: HP \r\n Price: 9, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("HP14SDK1062AU", "Name: HP 14S - DK1062AU \r\n Brand: HP \r\n Price: 10, 390, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("HP14SDQ1022TU", "Name: HP 14S - DQ1022TU \r\n Brand: HP \r\n Price: 17, 690, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HP15DA0037TX", "Name: HP 15 - DA0037TX \r\n Brand: HP \r\n Price: 10, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 500GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HP15SDU0054TU", "Name: HP 15S - DU0054TU \r\n Brand: HP \r\n Price: 10, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("HP15SDU0126TU", "Name: HP 15S - DU0126TU \r\n Brand: HP \r\n Price: 10, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP15SDU1037TX", "Name: HP 15S - DU1037TX \r\n Brand: HP \r\n Price: 16, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HP15SDU1040TX", "Name: HP 15S - DU1040TX \r\n Brand: HP \r\n Price: 18, 090, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HP15SFQ1021TU", "Name: HP 15S - FQ1021TU \r\n Brand: HP \r\n Price: 15, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP15SFQ1107TU", "Name: HP 15S - FQ1107TU \r\n Brand: HP \r\n Price: 10, 240, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP15SFQ1109TU", "Name: HP 15S - FQ1109TU \r\n Brand: HP \r\n Price: 11, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP15SFQ1116TU", "Name: HP 15S - FQ1116TU \r\n Brand: HP \r\n Price: 12, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP348G5", "Name: HP 348 G5 \r\n Brand: HP \r\n Price: 14, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("HP348G7", "Name: HP 348 G7 \r\n Brand: HP \r\n Price: 10, 790, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPNOTEBOOK14SDQ1020TU", "Name: HP NOTEBOOK 14S - DQ1020TU \r\n Brand: HP \r\n Price: 14, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE3015TU", "Name: HP PAVILION 14 CE3015TU \r\n Brand: HP \r\n Price: 13, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE1014TU", "Name: HP PAVILION 14 - CE1014TU \r\n Brand: HP \r\n Price: 12, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 500GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("HPPAVILION14CE2036TU", "Name: HP PAVILION 14 - CE2036TU \r\n Brand: HP \r\n Price: 12, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 500GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("HPPAVILION14CE2039TU", "Name: HP PAVILION 14 - CE2039TU \r\n Brand: HP \r\n Price: 15, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE2040TU", "Name: HP PAVILION 14 - CE2040TU \r\n Brand: HP \r\n Price: 14, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE3018TU", "Name: HP PAVILION 14 - CE3018TU \r\n Brand: HP \r\n Price: 15, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE3026TU", "Name: HP PAVILION 14 - CE3026TU \r\n Brand: HP \r\n Price: 16, 390, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS0016TU", "Name: HP PAVILION 15 - CS0016TU \r\n Brand: HP \r\n Price: 12, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS1045TX", "Name: HP PAVILION 15 - CS1045TX \r\n Brand: HP \r\n Price: 16, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILION15CS2001TU", "Name: HP PAVILION 15 - CS2001TU \r\n Brand: HP \r\n Price: 12, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS2031TU", "Name: HP PAVILION 15 - CS2031TU \r\n Brand: HP \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS2033TU", "Name: HP PAVILION 15 - CS2033TU \r\n Brand: HP \r\n Price: 15, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("HPPAVILION15CS2035TU", "Name: HP PAVILION 15 - CS2035TU \r\n Brand: HP \r\n Price: 16, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS2056TX", "Name: HP PAVILION 15 - CS2056TX \r\n Brand: HP \r\n Price: 15, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILION15CS3008TU", "Name: HP PAVILION 15 - CS3008TU \r\n Brand: HP \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS3011TU", "Name: HP PAVILION 15 - CS3011TU \r\n Brand: HP \r\n Price: 16, 690, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS3060TX", "Name: HP PAVILION 15 - CS3060TX \r\n Brand: HP \r\n Price: 17, 590, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILION15CS3116TX", "Name: HP PAVILION 15 - CS3116TX \r\n Brand: HP \r\n Price: 16, 090, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILIONX36014CD1018TU", "Name: HP PAVILION X360 14 - CD1018TU \r\n Brand: HP \r\n Price: 13, 490, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILIONX36014DH0103TU", "Name: HP PAVILION X360 14 - DH0103TU \r\n Brand: HP \r\n Price: 13, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILIONX36014DH1137TU", "Name: HP PAVILION X360 14 - DH1137TU \r\n Brand: HP \r\n Price: 13, 690, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILIONX36014DH1138TU", "Name: HP PAVILION X360 14 - DH1138TU \r\n Brand: HP \r\n Price: 17, 790, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILIONX36014DW0061TU", "Name: HP PAVILION X360 14 - DW0061TU \r\n Brand: HP \r\n Price: 14, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPROBOOK440G7", "Name: HP PROBOOK 440 G7 \r\n Brand: HP \r\n Price: 13, 190, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPROBOOK440G7I5", "Name: HP PROBOOK 440 G7 \r\n Brand: HP \r\n Price: 17, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");

            description.Add("LENOVOIDEAPAD33015IKB", "Name: LENOVO IDEAPAD 330 - 15IKB \r\n Brand: Lenovo \r\n Price: 9, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("LENOVOIDEAPADC34014API", "Name: LENOVO IDEAPAD C340 - 14API \r\n Brand: Lenovo \r\n Price: 14, 940, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADC34014APIR7", "Name: LENOVO IDEAPAD C340 - 14API \r\n Brand: Lenovo \r\n Price: 17, 440, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADL34015IRH", "Name: LENOVO IDEAPAD L340 - 15IRH \r\n Brand: Lenovo \r\n Price: 16, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("LENOVOIDEAPADL34015IRHI7", "Name: LENOVO IDEAPAD L340 - 15IRH \r\n Brand: Lenovo \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("LENOVOIDEAPADS14515API", "Name: LENOVO IDEAPAD S145 - 15API \r\n Brand: Lenovo \r\n Price: 10, 440, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADS14515API8GB", "Name: LENOVO IDEAPAD S145 - 15API \r\n Brand: Lenovo \r\n Price: 11, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADS14515IIL", "Name: LENOVO IDEAPAD S145 - 15IIL \r\n Brand: Lenovo \r\n Price: 14, 290, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS14515IIL8GB", "Name: LENOVO IDEAPAD S145 - 15IIL \r\n Brand: Lenovo \r\n Price: 14, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS14515IKB", "Name: LENOVO IDEAPAD S145 - 15IKB \r\n Brand: Lenovo \r\n Price: 9, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("LENOVOIDEAPADS340", "Name: LENOVO IDEAPAD S340 \r\n Brand: Lenovo \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADS34014IIL", "Name: LENOVO IDEAPAD S340 - 14IIL \r\n Brand: Lenovo \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS34014IILI5", "Name: LENOVO IDEAPAD S340 - 14IIL \r\n Brand: Lenovo \r\n Price: 14, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS34015API", "Name: LENOVO IDEAPAD S340 - 15API \r\n Brand: Lenovo \r\n Price: 12, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADS34015IWL", "Name: LENOVO IDEAPAD S340 - 15IWL \r\n Brand: Lenovo \r\n Price: 11, 440, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS34015IWLI5", "Name: LENOVO IDEAPAD S340 - 15IWL \r\n Brand: Lenovo \r\n Price: 14, 990, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("LENOVOLEGION515ARH05", "Name: LENOVO LEGION 5 - 15ARH05 \r\n Brand: Lenovo \r\n Price: 19, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("LENOVOLEGIONY54015IRH", "Name: LENOVO LEGION Y540 - 15IRH \r\n Brand: Lenovo \r\n Price: 19, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("LENOVOTHINKBOOK14", "Name: LENOVO THINKBOOK 14 \r\n Brand: Lenovo \r\n Price: 13, 140, 000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOTHINKBOOK14IIL", "Name: LENOVO THINKBOOK 14 \r\n Brand: Lenovo \r\n Price: 15, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOTHINKBOOK15", "Name: LENOVO THINKBOOK 15 \r\n Brand: Lenovo \r\n Price: 17, 440, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOTHINKPADE14", "Name: LENOVO THINKPAD E14 \r\n Brand: Lenovo \r\n Price: 18, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOTHINKPADE490", "Name: LENOVO THINKPAD E490 \r\n Brand: Lenovo \r\n Price: 17, 940, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");

            description.Add("MACBOOKAIR132019", "Name: MACBOOK AIR 13 2019 \r\n Brand: Macbook \r\n Price: 32, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel UHD");
            description.Add("MACBOOKAIR132020256GB", "Name: MACBOOK AIR 13 2020(256GB) \r\n Brand: Macbook \r\n Price: 28, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKAIR132020512GB", "Name: MACBOOK AIR 13 2020(512GB) \r\n Brand: Macbook \r\n Price: 34, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKAIR13MQD32SA", "Name: MACBOOK AIR 13 MQD32SA \r\n Brand: Macbook \r\n Price: 19, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 13.3 \r\n GPU: Intel HD");
            description.Add("MACBOOKPRO13202014GHZ256GB", "Name: MACBOOK PRO 13 2020 1.4GHZ(256GB) \r\n Brand: Macbook \r\n Price: 34, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13202014GHZ512GB", "Name: MACBOOK PRO 13 2020 1.4GHZ(512GB) \r\n Brand: Macbook \r\n Price: 39, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13202020GHZ1TB", "Name: MACBOOK PRO 13 2020 2.0GHZ(1TB) \r\n Brand: Macbook \r\n Price: 54, 990, 000 ₫ \r\n RAM: 16GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 1TB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13202020GHZ512GB", "Name: MACBOOK PRO 13 2020 2.0GHZ(512GB) \r\n Brand: Macbook \r\n Price: 47, 990, 000 ₫ \r\n RAM: 16GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13TOUCHBAR128GB", "Name: MACBOOK PRO 13 TOUCH BAR(128GB) \r\n Brand: Macbook \r\n Price: 31, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13TOUCHBAR256GB", "Name: MACBOOK PRO 13 TOUCH BAR(256GB) \r\n Brand: Macbook \r\n Price: 44, 490, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13TOUCHBAR512GB", "Name: MACBOOK PRO 13 TOUCH BAR(512GB) \r\n Brand: Macbook \r\n Price: 51, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO16TOUCHBARCOREI9", "Name: MACBOOK PRO 16 TOUCH BAR 2.3GHZ(CORE I9) \r\n Brand: Macbook \r\n Price: 69, 990, 000 ₫ \r\n RAM: 16GB \r\n CPU: Core i9 \r\n Hardware: SSD \r\n Diskspace: 1TB \r\n Screen Size: 16 \r\n GPU: AMD");
            description.Add("MACBOOKPRO16TOUCHBARCOREI7", "Name: MACBOOK PRO 16 TOUCH BAR 2.6GHZ(CORE I7) \r\n Brand: Macbook \r\n Price: 59, 990, 000 ₫ \r\n RAM: 16GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 16 \r\n GPU: AMD");

            description.Add("MSIALPHA15A3DDK", "Name: MSI ALPHA 15 A3DDK \r\n Brand: MSI \r\n Price: 24, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("MSIBRAVO15A4DCR070VN", "Name: MSI BRAVO 15 A4DCR - 070VN \r\n Brand: MSI \r\n Price: 20, 290, 000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("MSIGF638RC203VN", "Name: MSI GF63 8RC - 203VN \r\n Brand: MSI \r\n Price: 21, 990, 000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGF639SC070VN", "Name: MSI GF63 9SC-070VN \r\n Brand: MSI \r\n Price: 25,390,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGF639SC400VN", "Name: MSI GF63 9SC-400VN \r\n Brand: MSI \r\n Price: 19,990,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGF639SCXR", "Name: MSI GF63 9SCXR \r\n Brand: MSI \r\n Price: 20,440,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGF639SCXR075VN", "Name: MSI GF63 9SCXR-075VN \r\n Brand: MSI \r\n Price: 20,890,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGF63THIN10SCXR427VN", "Name: MSI GF63 THIN 10SCXR-427VN \r\n Brand: MSI \r\n Price: 21,440,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIGS659SD", "Name: MSI GS65 9SD \r\n Brand: MSI \r\n Price: 34,190,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("MSIMODERN14A10M", "Name: MSI MODERN 14 A10M \r\n Brand: MSI \r\n Price: 17,940,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("MSIMODERN15A10M", "Name: MSI MODERN 15 A10M \r\n Brand: MSI \r\n Price: 23,440,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");


            description.Add("ACERAPIREA3155434U1O", "Name: ACER APIRE A315 54 34U1 \r\n Brand: Acer \r\n Price: 7,304,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE3A31554K37B0O", "Name: ACER ASPIRE 3 A315 54K 37B0 \r\n Brand: Acer \r\n Price: 7,469,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE3A3155637DVO", "Name: ACER ASPIRE 3 A315 56 37DV \r\n Brand: Acer \r\n Price: 8,151,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIRE3A3155659XYO", "Name: ACER ASPIRE 3 A315 56 59XY \r\n Brand: Acer \r\n Price: 9,647,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERASPIREA31542R4XDO", "Name: ACER ASPIRE A315 42 R4XD \r\n Brand: Acer \r\n Price: 9,515,000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("ACERASPIREA5155436H3O", "Name: ACER ASPIRE A515-54-36H3 \r\n Brand: Acer \r\n Price: 7,799,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ACERSWIFTSF31456596EO", "Name: ACER SWIFT SF314-56-596E \r\n Brand: Acer \r\n Price: 11,209,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");

            description.Add("ASUSA412FAEK740TO", "Name: ASUS A412FA-EK740T \r\n Brand: Asus \r\n Price: 13,992,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("ASUSF571GTBQ532TO", "Name: ASUS F571GT-BQ532T \r\n Brand: Asus \r\n Price: 15,191,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKA412DAEK160TO", "Name: ASUS VIVOBOOK A412DA-EK160T \r\n Brand: Asus \r\n Price: 11,594,000 ₫ \r\n RAM: 8GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKA412DAEK347TO", "Name: ASUS VIVOBOOK A412DA-EK347T \r\n Brand: Asus \r\n Price: 9,196,000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("ASUSVIVOBOOKA412FAEK380TO", "Name: ASUS VIVOBOOK A412FA-EK380T \r\n Brand: Asus \r\n Price: 9,988,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKA512FLEJ251TO", "Name: ASUS VIVOBOOK A512FL-EJ251T \r\n Brand: Asus \r\n Price: 13,189,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKA512FLEJ507TO", "Name: ASUS VIVOBOOK A512FL-EJ507T \r\n Brand: Asus \r\n Price: 14,388,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKD509DAEJ448TO", "Name: ASUS VIVOBOOK D509DA-EJ448T \r\n Brand: Asus \r\n Price: 8,635,000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("SUSVIVOBOOKFLIPTP412FAEC122TO", "Name: ASUS VIVOBOOK FLIP TP412FA-EC122T \r\n Brand: Asus \r\n Price: 13,915,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX407UABV537TO", "Name: ASUS VIVOBOOK X407UA-BV537T \r\n Brand: Asus \r\n Price: 7,832,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX409FAEK098TO", "Name: ASUS VIVOBOOK X409FA-EK098T \r\n Brand: Asus \r\n Price: 7,909,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX507UAEJ234TO", "Name: ASUS VIVOBOOK X507UA-EJ234T \r\n Brand: Asus \r\n Price: 8,228,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX509FAEJ560TO", "Name: ASUS VIVOBOOK X509FA-EJ560T \r\n Brand: Asus \r\n Price: 11,231,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKX509FJEJ225TO", "Name: ASUS VIVOBOOK X509FJ-EJ225T \r\n Brand: Asus \r\n Price: 11,429,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX509FJEJ314TO", "Name: ASUS VIVOBOOK X509FJ-EJ314T \r\n Brand: Asus \r\n Price: 12,474,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("ASUSVIVOBOOKX509JAEJ171TO", "Name: ASUS VIVOBOOK X509JA-EJ171T \r\n Brand: Asus \r\n Price: 11,748,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("ASUSVIVOBOOKX509UABR011TO", "Name: ASUS VIVOBOOK X509UA-BR011T \r\n Brand: Asus \r\n Price: 8,393,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("ASUSVIVOBOOKX509UABR236TO", "Name: ASUS VIVOBOOK X509UA-BR236T \r\n Brand: Asus \r\n Price: 9,196,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");

            description.Add("DELLINSPIRONN3476BO", "Name: DELL INSPIRON N3476B \r\n Brand: Dell \r\n Price: 11,990,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3481UHDO", "Name: DELL INSPIRON N3481 \r\n Brand: Dell \r\n Price: 8,459,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3481O", "Name: DELL INSPIRON N3481 \r\n Brand: Dell \r\n Price: 9,097,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3493O", "Name: DELL INSPIRON N3493 \r\n Brand: Dell \r\n Price: 8,679,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN3580O", "Name: DELL INSPIRON N3580 \r\n Brand: Dell \r\n Price: 11,836,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN3581O", "Name: DELL INSPIRON N3581 \r\n Brand: Dell \r\n Price: 8,998,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("DELLINSPIRONN5584O", "Name: DELL INSPIRON N5584 \r\n Brand: Dell \r\n Price: 13,310,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN5593O", "Name: DELL INSPIRON N5593 \r\n Brand: Dell \r\n Price: 10,912,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLINSPIRONN5593I5O", "Name: DELL INSPIRON N5593 \r\n Brand: Dell \r\n Price: 15,004,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("DELLVOSTROV3490O", "Name: DELL VOSTRO V3490 \r\n Brand: Dell \r\n Price: 11,924,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV3590O", "Name: DELL VOSTRO V3590 \r\n Brand: Dell \r\n Price: 9,592,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5481O", "Name: DELL VOSTRO V5481 \r\n Brand: Dell \r\n Price: 13,673,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel HD");
            description.Add("DELLVOSTROV5490O", "Name: DELL VOSTRO V5490 \r\n Brand: Dell \r\n Price: 11,385,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5581O", "Name: DELL VOSTRO V5581 \r\n Brand: Dell \r\n Price: 13,497,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("DELLVOSTROV5590O", "Name: DELL VOSTRO V5590 \r\n Brand: Dell \r\n Price: 16,973,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");

            description.Add("HP14SDK0117AUO", "Name: HP 14S-DK0117AU \r\n Brand: HP \r\n Price: 7,150,000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: AMD");
            description.Add("HP15DA0037TXO", "Name: HP 15-DA0037TX \r\n Brand: HP \r\n Price: 7,447,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 500GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HP15SDU0126TUO", "Name: HP 15S-DU0126TU \r\n Brand: HP \r\n Price: 7,656,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HP15SDU1040TXO", "Name: HP 15S-DU1040TX \r\n Brand: HP \r\n Price: 13,640,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i7 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILION14CE3015TUO", "Name: HP PAVILION 14 CE3015TU \r\n Brand: HP \r\n Price: 10,076,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION14CE2040TUO", "Name: HP PAVILION 14-CE2040TU \r\n Brand: HP \r\n Price: 10,582,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS0016TUO", "Name: HP PAVILION 15-CS0016TU \r\n Brand: HP \r\n Price: 9,119,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS2056TXO", "Name: HP PAVILION 15-CS2056TX \r\n Brand: HP \r\n Price: 11,308,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILION15CS3008TUO", "Name: HP PAVILION 15-CS3008TU \r\n Brand: HP \r\n Price: 9,713,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS3011TUO", "Name: HP PAVILION 15-CS3011TU \r\n Brand: HP \r\n Price: 12,551,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("HPPAVILION15CS3116TXO", "Name: HP PAVILION 15-CS3116TX \r\n Brand: HP \r\n Price: 11,946,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");
            description.Add("HPPAVILIONX36014CD1018TUO", "Name: HP PAVILION X360 14-CD1018TU \r\n Brand: HP \r\n Price: 9,845,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: HDD \r\n Diskspace: 1TB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPAVILIONX36014DH1137TUO", "Name: HP PAVILION X360 14-DH1137TU \r\n Brand: HP \r\n Price: 10,208,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("HPPROBOOK440G7O", "Name: HP PROBOOK 440 G7 \r\n Brand: HP \r\n Price: 9,713,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");

            description.Add("LENOVOIDEAPAD33015IKBO", "Name: LENOVO IDEAPAD 330-15IKB \r\n Brand: Lenovo \r\n Price: 6,490,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel HD");
            description.Add("LENOVOIDEAPADS14514IKBO", "Name: LENOVO IDEAPAD S145-14IKB \r\n Brand: Lenovo \r\n Price: 7,128,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 14 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS340O", "Name: LENOVO IDEAPAD S340 \r\n Brand: Lenovo \r\n Price: 8,569,000 ₫ \r\n RAM: 4GB \r\n CPU: Ryzen 5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: AMD");
            description.Add("LENOVOIDEAPADS34015IWLO", "Name: LENOVO IDEAPAD S340-15IWL \r\n Brand: Lenovo \r\n Price: 7,436,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i3 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Intel UHD");
            description.Add("LENOVOIDEAPADS34015IWLI5O", "Name: LENOVO IDEAPAD S340-15IWL \r\n Brand: Lenovo \r\n Price: 10,197,000 ₫ \r\n RAM: 4GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 15.6 \r\n GPU: Nvidia");

            description.Add("MACBOOKAIR132019O", "Name: MACBOOK AIR 13 2019 \r\n Brand: Macbook \r\n Price: 25,894,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel UHD");
            description.Add("MACBOOKAIR13MQD32SAO", "Name: MACBOOK AIR 13 MQD32SA \r\n Brand: Macbook \r\n Price: 13,316,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 13.3 \r\n GPU: Intel HD");
            description.Add("MACBOOKPRO13TOUCHBAR128GBO", "Name: MACBOOK PRO 13 TOUCH BAR (128GB) \r\n Brand: Macbook \r\n Price: 26,213,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 128GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13TOUCHBAR256GBO", "Name: MACBOOK PRO 13 TOUCH BAR (256GB) \r\n Brand: Macbook \r\n Price: 30,789,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 256GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");
            description.Add("MACBOOKPRO13TOUCHBAR512GBO", "Name: MACBOOK PRO 13 TOUCH BAR (512GB) \r\n Brand: Macbook \r\n Price: 38,489,000 ₫ \r\n RAM: 8GB \r\n CPU: Core i5 \r\n Hardware: SSD \r\n Diskspace: 512GB \r\n Screen Size: 13.3 \r\n GPU: Intel Iris Plus");

            description.Add("NONE", "404 not found");
        }

        private void BuildImage()
        {
            image.Add("ACERAPIREA3155434U1", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Apire A315 54 34U1.png");
            image.Add("ACERASPIRE3A31554K37B0", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 1.png");
            image.Add("ACERASPIRE3A31523R8BA", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 4.png");
            image.Add("ACERASPIRE3A3155457PJ", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire.png");
            image.Add("ACERASPIRE5A51453346U", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 3.png");
            image.Add("ACERASPIRE5A5145350P9", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire.png");
            image.Add("ACERASPIRE5A514533821", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 4.png");
            image.Add("ACERASPIRE5A51554G56JG", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 3.png");
            image.Add("ACERASPIREA31542R4XD", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 2.png");
            image.Add("ACERASPIREA31554368N", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire.png");
            image.Add("ACERASPIREA51451525E", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 4.png");
            image.Add("ACERASPIREA5155436H3", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 4.png");
            image.Add("ACERASPIREE547650SZ", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 3.png");
            image.Add("ACERASPIREE5576G88EP", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 2.png");
            image.Add("ACERASPRIREA5155350ZD", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 1.png");

            image.Add("ACERNITRO5AN51543R65L", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Nitro 1.png");
            image.Add("ACERNITRO5AN51543R9FD", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Nitro.png");
            image.Add("ACERNITROAN5155459SF", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Nitro.png");

            image.Add("ACERSWIFT3SF31456G78QS", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 1.png");
            image.Add("ACERSWIFT3SF31441R8VS", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 2.png");
            image.Add("ACERSWIFT3SSF3145752GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift.png");
            image.Add("ACERSWIFTSF31456596E", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 4.png");
            image.Add("ACERSWIFTSF31541R0DX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 3.png");
            image.Add("ACERSWIFTSF3155238YQ", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 1.png");

            image.Add("ASUS14D409DAEK151T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus D409DA EK151T.jpg");
            image.Add("ASUSA412FAEK734T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10038127_asus-i5-8250u-15-6inch-x507uf-ej078t-1.jpg");
            image.Add("ASUSA412FAEK740T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus A412FA-EK740T.png");
            image.Add("ASUSA512DAEJ406T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10041607-asus-ryzen-5-2500u-15-6-inch-x505za-ej505t-1.jpg");
            image.Add("ASUSA512FAEJ837T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10045072-asus-a412fa-i5-14-inch-10210u-ek734t-1.jpg");
            image.Add("ASUSA512FLEJ165T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046035-asus-a412da-r5-3500u-14-inch-ek144t-1.jpg");
            image.Add("ASUSA512FLEJ163T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046035-asus-a412da-r5-3500u-14-inch-ek144t-1.jpg");
            image.Add("ASUSD570DDE4027T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus D570DD-E4027T.png");
            image.Add("ASUSD570DDE4028T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10038127_asus-i5-8250u-15-6inch-x507uf-ej078t-1.jpg");
            image.Add("ASUSF571GTBQ532T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10045072-asus-a412fa-i5-14-inch-10210u-ek734t-1.jpg");
            image.Add("ASUSFX505DTAL003T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10041607-asus-ryzen-5-2500u-15-6-inch-x505za-ej505t-1.jpg");

            image.Add("ASUSTUFFX505DYAL060T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus TUF 1.png");
            image.Add("ASUSTUFFX505DYAL133T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus TUF 2.png");
            image.Add("ASUSTUFFX505GTAL003T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus TUF.png");

            image.Add("ASUSVIVOBOOKA412DAEK144T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKA412DAEK160T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook.png");
            image.Add("ASUSVIVOBOOKA412DAEK347T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10042835_mtxt-asus-vivobook-i3-8145u-a512fa-ej099t-1.jpg");
            image.Add("ASUSVIVOBOOKA412FAEK380T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046568-asus-vivobook-14-a412fa-i3-10110u-14-inch-ek1188t-1.jpg");
            image.Add("ASUSVIVOBOOKA412FAEK647T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKA512FAEJ099T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSVIVOBOOKA512FLEJ507T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSVIVOBOOKD409DAEK109T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKD509DAEJ448T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10042835_mtxt-asus-vivobook-i3-8145u-a512fa-ej099t-1.jpg");
            image.Add("ASUSVIVOBOOKFLIPTP412FAEC122T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKM413IAEK480T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook.png");
            image.Add("ASUSVIVOBOOKS431FAEB141T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046568-asus-vivobook-14-a412fa-i3-10110u-14-inch-ek1188t-1.jpg");
            image.Add("ASUSVIVOBOOKTP412FAEC268T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX407UABV537T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSVIVOBOOKX409FAEK098T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX507UAEJ234T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX507UFEJ078T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046568-asus-vivobook-14-a412fa-i3-10110u-14-inch-ek1188t-1.jpg");
            image.Add("ASUSVIVOBOOKX507UFEJ079T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSVIVOBOOKX509FAEJ560T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX509FJEJ314T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX509JAEJ171T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046568-asus-vivobook-14-a412fa-i3-10110u-14-inch-ek1188t-1.jpg");
            image.Add("ASUSVIVOBOOKX509JPEJ014T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook.png");
            image.Add("ASUSVIVOBOOKX509UABR011T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10044377-asus-vivobook-x509fj-i5-8265u-15-6-inch-ej153t-1.jpg");
            image.Add("ASUSVIVOBOOKX509UABR236T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSX505ZAEJ505T", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10043849_MTXT_ASUS_X509FA-EJ201T-I5-4-1-W10_01_mpf3-32.jpg");

            image.Add("DELLINSPIRONN3476B", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron.png");
            image.Add("DELLINSPIRONN3481", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 2.png");
            image.Add("DELLINSPIRONN3481UHD", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 3.png");
            image.Add("DELLINSPIRONN3493", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 4.png");
            image.Add("DELLINSPIRONN3493I5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 1.png");
            image.Add("DELLINSPIRONN3580", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 2.png");
            image.Add("DELLINSPIRONN3580A", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 3.png");
            image.Add("DELLINSPIRONN3581", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 4.png");
            image.Add("DELLINSPIRONN3593C", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 4.png");
            image.Add("DELLINSPIRONN3593D", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 1.png");
            image.Add("DELLINSPIRONN5584", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron.png");
            image.Add("DELLINSPIRONN5593", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 4.png");
            image.Add("DELLINSPIRONN5593I5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 2.png");

            image.Add("DELLV3590", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell V3590.png");
            image.Add("DELLVOSTRO5481", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 2.png");
            image.Add("DELLVOSTROV3480", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 3.png");
            image.Add("DELLVOSTROV3481", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 4.png");
            image.Add("DELLVOSTROV3490", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro.png");
            image.Add("DELLVOSTROV3590", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 4.png");
            image.Add("DELLVOSTROV5481", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 3.png");
            image.Add("DELLVOSTROV5490", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro.png");
            image.Add("DELLVOSTROV5581", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 1.png");
            image.Add("DELLVOSTROV5590", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 3.png");

            image.Add("HP14SDK0117AU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 1.jpg");
            image.Add("HP14SDK0132AU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 3.jpg");
            image.Add("HP14SDK1055AU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 2.jpg");
            image.Add("HP14SDK1062AU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 4.jpg");
            image.Add("HP14SDQ1022TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 5.jpg");
            image.Add("HP15DA0037TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 7.jpg");
            image.Add("HP15SDU0054TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 6.jpg");
            image.Add("HP15SDU0126TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 8.jpg");
            image.Add("HP15SDU1037TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 9.jpg");
            image.Add("HP15SDU1040TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 3.jpg");
            image.Add("HP15SFQ1021TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 2.jpg");
            image.Add("HP15SFQ1107TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 5.jpg");
            image.Add("HP15SFQ1109TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 7.jpg");
            image.Add("HP15SFQ1116TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 1.jpg");
            image.Add("HP348G5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP.jpg");
            image.Add("HP348G7", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP.jpg");
            image.Add("HPNOTEBOOK14SDQ1020TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION14CE3015TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION14CE1014TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION14CE2036TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION14CE2039TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION14CE2040TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION14CE3018TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION14CE3026TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS0016TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS1045TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS2001TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS2031TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS2033TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS2035TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS2056TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS3008TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS3011TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS3060TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS3116TX", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILIONX36014CD1018TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion x360.png");
            image.Add("HPPAVILIONX36014DH0103TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion x360.png");
            image.Add("HPPAVILIONX36014DH1137TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion x360.png");
            image.Add("HPPAVILIONX36014DH1138TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion x360.png");
            image.Add("HPPAVILIONX36014DW0061TU", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion x360.png");
            image.Add("HPPROBOOK440G7", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Probook.png");
            image.Add("HPPROBOOK440G7I5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Probook.png");

            image.Add("LENOVOIDEAPAD33015IKB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADC34014API", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADC34014APIR7", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADL34015IRH", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADL34015IRHI7", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14515API", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14515API8GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14515IIL", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14515IIL8GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14515IKB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS340", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS34014IIL", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS34014IILI5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS34015API", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS34015IWL", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS34015IWLI5", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOLEGION515ARH05", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Legion.png");
            image.Add("LENOVOLEGIONY54015IRH", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Legion.png");
            image.Add("LENOVOTHINKBOOK14", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo 1.jpg");
            image.Add("LENOVOTHINKBOOK14IIL", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo 1.jpg");
            image.Add("LENOVOTHINKBOOK15", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo 1.jpg");
            image.Add("LENOVOTHINKPADE14", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo 1.jpg");
            image.Add("LENOVOTHINKPADE490", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo 1.jpg");

            image.Add("MACBOOKAIR132019", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 1.png");
            image.Add("MACBOOKAIR132020256GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 2.jpg");
            image.Add("MACBOOKAIR132020512GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air.png");
            image.Add("MACBOOKAIR13MQD32SA", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 3.jpg");
            image.Add("MACBOOKPRO13202014GHZ256GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 3.jpg");
            image.Add("MACBOOKPRO13202014GHZ512GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 2.png");
            image.Add("MACBOOKPRO13202020GHZ1TB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 1.png");
            image.Add("MACBOOKPRO13202020GHZ512GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro.png");
            image.Add("MACBOOKPRO13TOUCHBAR128GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 3.jpg");
            image.Add("MACBOOKPRO13TOUCHBAR256GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 1.png");
            image.Add("MACBOOKPRO13TOUCHBAR512GB", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro.png");
            image.Add("MACBOOKPRO16TOUCHBARCOREI9", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 3.jpg");
            image.Add("MACBOOKPRO16TOUCHBARCOREI7", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 1.png");

            image.Add("MSIALPHA15A3DDK", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 1.png");
            image.Add("MSIBRAVO15A4DCR070VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI.png");
            image.Add("MSIGF638RC203VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 2.png");
            image.Add("MSIGF639SC070VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 3.png");
            image.Add("MSIGF639SC400VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI.png");
            image.Add("MSIGF639SCXR", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 4.jpg");
            image.Add("MSIGF639SCXR075VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 5.jpg");
            image.Add("MSIGF63THIN10SCXR427VN", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 2.png");
            image.Add("MSIGS659SD", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 5.jpg");
            image.Add("MSIMODERN14A10M", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 4.jpg");
            image.Add("MSIMODERN15A10M", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\MSI\\MSI 1.png");

            image.Add("ACERAPIREA3155434U1O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Apire A315 54 34U1.png");
            image.Add("ACERASPIRE3A31554K37B0O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer 1.jpg");
            image.Add("ACERASPIRE3A3155637DVO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer 2.jpg");
            image.Add("ACERASPIRE3A3155659XYO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 2.png");
            image.Add("ACERASPIREA31542R4XDO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 3.png");
            image.Add("ACERASPIREA5155436H3O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Aspire 1.png");
            image.Add("ACERSWIFTSF31456596EO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Acer\\Acer Swift 1.png");

            image.Add("ASUSA412FAEK740TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10045072-asus-a412fa-i5-14-inch-10210u-ek734t-1.jpg");
            image.Add("ASUSF571GTBQ532TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10041690-asus-i3-8145u-14-inch-a412fa-ek-155t-bac-1.jpg");
            image.Add("ASUSVIVOBOOKA412DAEK160TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10044377-asus-vivobook-x509fj-i5-8265u-15-6-inch-ej153t-1.jpg");
            image.Add("ASUSVIVOBOOKA412DAEK347TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046568-asus-vivobook-14-a412fa-i3-10110u-14-inch-ek1188t-1.jpg");
            image.Add("ASUSVIVOBOOKA412FAEK380TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046569-asus-vivobook-15-a512fa-i3-10110u-15-6-inch-ej2006t-1.jpg");
            image.Add("ASUSVIVOBOOKA512FLEJ251TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook.png");
            image.Add("ASUSVIVOBOOKA512FLEJ507TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKD509DAEJ448TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook.png");
            image.Add("SUSVIVOBOOKFLIPTP412FAEC122TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\Asus Vivobook 1.png");
            image.Add("ASUSVIVOBOOKX407UABV537TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10045072-asus-a412fa-i5-14-inch-10210u-ek734t-1.jpg");
            image.Add("ASUSVIVOBOOKX409FAEK098TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046035-asus-a412da-r5-3500u-14-inch-ek144t-1.jpg");
            image.Add("ASUSVIVOBOOKX507UAEJ234TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10038127_asus-i5-8250u-15-6inch-x507uf-ej078t-1.jpg");
            image.Add("ASUSVIVOBOOKX509FAEJ560TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046035-asus-a412da-r5-3500u-14-inch-ek144t-1.jpg");
            image.Add("ASUSVIVOBOOKX509FJEJ225TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10043849_MTXT_ASUS_X509FA-EJ201T-I5-4-1-W10_01_mpf3-32.jpg");
            image.Add("ASUSVIVOBOOKX509FJEJ314TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10045072-asus-a412fa-i5-14-inch-10210u-ek734t-1.jpg");
            image.Add("ASUSVIVOBOOKX509JAEJ171TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10043849_MTXT_ASUS_X509FA-EJ201T-I5-4-1-W10_01_mpf3-32.jpg");
            image.Add("ASUSVIVOBOOKX509UABR011TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10038127_asus-i5-8250u-15-6inch-x507uf-ej078t-1.jpg");
            image.Add("ASUSVIVOBOOKX509UABR236TO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Asus\\10046035-asus-a412da-r5-3500u-14-inch-ek144t-1.jpg");

            image.Add("DELLINSPIRONN3476BO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron.png");
            image.Add("DELLINSPIRONN3481O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 2.png");
            image.Add("DELLINSPIRONN3481UHDO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 1.png");
            image.Add("DELLINSPIRONN3493O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 3.png");
            image.Add("DELLINSPIRONN3580O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 1.png");
            image.Add("DELLINSPIRONN3581O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 4.png");
            image.Add("DELLINSPIRONN5584O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 1.png");
            image.Add("DELLINSPIRONN5593O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron 2.png");
            image.Add("DELLINSPIRONN5593I5O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Inspiron.png");
            image.Add("DELLVOSTROV3490O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro.png");
            image.Add("DELLVOSTROV3590O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 1.png");
            image.Add("DELLVOSTROV5481O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 2.png");
            image.Add("DELLVOSTROV5490O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 4.png");
            image.Add("DELLVOSTROV5581O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro.png");
            image.Add("DELLVOSTROV5590O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Dell\\Dell Vostro 3.png");

            image.Add("HP14SDK0117AUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 1.jpg");
            image.Add("HP15DA0037TXO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 10.jpg");
            image.Add("HP15SDU0126TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 2.jpg");
            image.Add("HP15SDU1040TXO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 3.jpg");
            image.Add("HPPAVILION14CE3015TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 4.jpg");
            image.Add("HPPAVILION14CE2040TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS0016TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS2056TXO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 5.jpg");
            image.Add("HPPAVILION15CS3008TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPAVILION15CS3011TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILION15CS3116TXO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP 6.jpg");
            image.Add("HPPAVILIONX36014CD1018TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion.png");
            image.Add("HPPAVILIONX36014DH1137TUO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Pavilion 1.jpg");
            image.Add("HPPROBOOK440G7O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\HP\\HP Probook.png");

            image.Add("LENOVOIDEAPAD33015IKBO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 1.png");
            image.Add("LENOVOIDEAPADS14514IKBO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 2.png");
            image.Add("LENOVOIDEAPADS340O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 3.png");
            image.Add("LENOVOIDEAPADS34015IWLO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad.png");
            image.Add("LENOVOIDEAPADS34015IWLI5O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Lenovo\\Lenovo Ideapad 4.png");

            image.Add("MACBOOKAIR132019O", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 1.png");
            image.Add("MACBOOKAIR13MQD32SAO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Air 3.jpg");
            image.Add("MACBOOKPRO13TOUCHBAR128GBO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 2.png");
            image.Add("MACBOOKPRO13TOUCHBAR256GBO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 3.jpg");
            image.Add("MACBOOKPRO13TOUCHBAR512GBO", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\Macbook\\Macbook Pro 1.png");

            image.Add("NONE", "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\notfound.png");
        }

        private void BuildLink()
        {
            link.Add("ACERAPIREA3155434U1", "https://fptshop.com.vn/may-tinh-xach-tay/acer-aspire-a315-54-34u-i3-10110u");
            link.Add("ACERASPIRE3A31554K37B0", "https://fptshop.com.vn/may-tinh-xach-tay/acer-aspire-3-a315-54k-37b0-i3-8130u");
            link.Add("ACERASPIRE3A31523R8BA", "https://www.nguyenkim.com/acer-r3-3250u-15.6-inch-a315-23-r8ba.html");
            link.Add("ACERASPIRE3A3155457PJ", "https://www.nguyenkim.com/laptop-acer-aspire-3-a315-54-57pj.html");
            link.Add("ACERASPIRE5A51453346U", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ACERASPIRE5A5145350P9", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("ACERASPIRE5A514533821", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ACERASPIRE5A51554G56JG", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("ACERASPIREA31542R4XD", "https://fptshop.com.vn/may-tinh-xach-tay/acer-aspire-a315-42-r4xd-r5-3500u");
            link.Add("ACERASPIREA31554368N", "https://fptshop.com.vn/may-tinh-xach-tay/acer-aspire-a315-54-368n-i3-10110u");
            link.Add("ACERASPIREA51451525E", "https://www.nguyenkim.com/laptop-acer-aspire-a514-51-525e-nx.h6vsv.002.html");
            link.Add("ACERASPIREA5155436H3", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ACERASPIREE547650SZ", "https://www.nguyenkim.com/laptop-acer-aspire-e5-476-50sz.html");
            link.Add("ACERASPIREE5576G88EP", "https://www.nguyenkim.com/laptop-acer-aspire-e5-576g-88ep.html");
            link.Add("ACERASPRIREA5155350ZD", "https://fptshop.com.vn/may-tinh-xach-tay/asprise-a515-53-50zd-core-i5-8265u");

            link.Add("ACERNITRO5AN51543R65L", "https://fptshop.com.vn/may-tinh-xach-tay/acer-nitro-5-an515-43-r65l-r7-3750h");
            link.Add("ACERNITRO5AN51543R9FD", "https://fptshop.com.vn/may-tinh-xach-tay/acer-nitro-an515-43-r9fd-r5-3550h");
            link.Add("ACERNITROAN5155459SF", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&card-do-hoa=nvidia-geforce-series&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");

            link.Add("ACERSWIFT3SF31456G78QS", "https://fptshop.com.vn/may-tinh-xach-tay/acer-swift-3-sf314-56g-78qs-i7-8565u");
            link.Add("ACERSWIFT3SF31441R8VS", "https://www.nguyenkim.com/laptop-acer-swift-3-sf314-41-r8vs-r5-nx.hfdsv.002.html");
            link.Add("ACERSWIFT3SSF3145752GB", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("ACERSWIFTSF31456596E", "https://fptshop.com.vn/may-tinh-xach-tay/acer-swift-sf314-56-596e-core-i5-8265u");
            link.Add("ACERSWIFTSF31541R0DX", "https://fptshop.com.vn/may-tinh-xach-tay/acer-swift-sf315-41-r0dx-r5-2500u-8gb");
            link.Add("ACERSWIFTSF3155238YQ", "https://fptshop.com.vn/may-tinh-xach-tay/acer?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");

            link.Add("ASUS14D409DAEK151T", "https://www.nguyenkim.com/asus-14-d409da-r3-3200u-14.0-inch-d409da-ek151t.html");
            link.Add("ASUSA412FAEK734T", "https://www.nguyenkim.com/laptop-asus-a412fa-ek734t.html");
            link.Add("ASUSA412FAEK740T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSA512DAEJ406T", "https://www.nguyenkim.com/laptop-asus-a512da-ej406t.html");
            link.Add("ASUSA512FAEJ837T", "https://www.nguyenkim.com/laptop-asus-a512fa-ej837t.html");
            link.Add("ASUSA512FLEJ165T", "https://www.nguyenkim.com/laptop-asus-a512fl-ej165t.html");
            link.Add("ASUSA512FLEJ163T", "https://www.nguyenkim.com/laptop-asus-a512fl-ej163t.html");
            link.Add("ASUSD570DDE4027T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-d570dd-e4027t-r5-3500u");
            link.Add("ASUSD570DDE4028T", "https://www.nguyenkim.com/laptop-asus-d570dd-e4028t.html");
            link.Add("ASUSF571GTBQ532T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSFX505DTAL003T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-fx505dt-al003t-r7-3750h-gtx1650");
            link.Add("ASUSTUFFX505DYAL060T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSTUFFX505DYAL133T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSTUFFX505GTAL003T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKA412DAEK144T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-10-15-trieu&ram=8-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKA412DAEK160T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-10-15-trieu&ram=8-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKA412DAEK347T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-a412da-ek347t-r3-3200u");
            link.Add("ASUSVIVOBOOKA412FAEK380T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-a412fa-ek380t-core-i3-8145u");
            link.Add("ASUSVIVOBOOKA412FAEK647T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKA512FAEJ099T", "https://www.nguyenkim.com/laptop-asus-vivobook-a512fa-ej099t.html");
            link.Add("ASUSVIVOBOOKA512FLEJ507T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKD409DAEK109T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-d409da-ek109t-r5-3500u");
            link.Add("ASUSVIVOBOOKD509DAEJ448T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-d509da-ej448t-r3-3200u");
            link.Add("ASUSVIVOBOOKFLIPTP412FAEC122T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-flip-tp412fa-ec122t-i5-8265u");
            link.Add("ASUSVIVOBOOKM413IAEK480T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-m413ia-ek480t-r5-4500u");
            link.Add("ASUSVIVOBOOKS431FAEB141T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKTP412FAEC268T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-tp412fa-ec268t-i3-8145u");
            link.Add("ASUSVIVOBOOKX407UABV537T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=duoi-10-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKX409FAEK098T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=duoi-10-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKX507UAEJ234T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-x507ua-ej234t-core-i3-7020u");
            link.Add("ASUSVIVOBOOKX507UFEJ078T", "https://www.nguyenkim.com/laptop-asus-x507uf-ej078t.html");
            link.Add("ASUSVIVOBOOKX507UFEJ079T", "https://www.nguyenkim.com/laptop-asus-x507uf-ej079t.html");
            link.Add("ASUSVIVOBOOKX509FAEJ560T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKX509FJEJ314T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-x509fj-ej314t-i5-8265u");
            link.Add("ASUSVIVOBOOKX509JAEJ171T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKX509JPEJ014T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-x509jp-ej014t-i5-1035g1");
            link.Add("ASUSVIVOBOOKX509UABR011T", "https://fptshop.com.vn/may-tinh-xach-tay/asus?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("ASUSVIVOBOOKX509UABR236T", "https://fptshop.com.vn/may-tinh-xach-tay/asus-vivobook-x509ua-br236t-core-i3-7020u");
            link.Add("ASUSX505ZAEJ505T", "https://www.nguyenkim.com/laptop-asus-x505za-ej505t.html");

            link.Add("DELLINSPIRONN3476B", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3476-core-i5-8250u-4gb-1tb-amd-520-radeon-2gb");
            link.Add("DELLINSPIRONN3481", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3481-core-i3-7020u-70187649");
            link.Add("DELLINSPIRONN3481UHD", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3481-core-i3-7020u-030cx1");
            link.Add("DELLINSPIRONN3493", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("DELLINSPIRONN3493I5", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3493-i5-1035g1-256gb");
            link.Add("DELLINSPIRONN3580", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3580-core-i5-8265u");
            link.Add("DELLINSPIRONN3580A", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3580a-core-i3-8145u");
            link.Add("DELLINSPIRONN3581", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n3581-core-i3-7020u");
            link.Add("DELLINSPIRONN3593C", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("DELLINSPIRONN3593D", "https://www.nguyenkim.com/laptop-dell-inspiron-n3593d-p75f013n93d-den.html");
            link.Add("DELLINSPIRONN5584", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n5584-core-i5-8265u");
            link.Add("DELLINSPIRONN5593", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("DELLINSPIRONN5593I5", "https://fptshop.com.vn/may-tinh-xach-tay/dell-inspiron-n5593-i5-1035g1-8gb-512gb");
            link.Add("DELLV3590", "https://fptshop.com.vn/may-tinh-xach-tay/dell-v3590-i5-10210u");
            link.Add("DELLVOSTRO5481", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-15-20-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("DELLVOSTROV3480", "https://fptshop.com.vn/may-tinh-xach-tay/dell-vostro-v3480-core-i5-8265u-4gb-70187647");
            link.Add("DELLVOSTROV3481", "https://fptshop.com.vn/may-tinh-xach-tay/dell-vostro-v3481-core-i3-7020u");
            link.Add("DELLVOSTROV3490", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("DELLVOSTROV3590", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat ");
            link.Add("DELLVOSTROV5481", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-15-20-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("DELLVOSTROV5490", "https://fptshop.com.vn/may-tinh-xach-tay/dell?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("DELLVOSTROV5581", "https://fptshop.com.vn/may-tinh-xach-tay/dell-vostro-v5581-core-i5-8265u-finger-70194504");
            link.Add("DELLVOSTROV5590", "https://fptshop.com.vn/may-tinh-xach-tay/dell-vostro-v5590-i5-10210u-8gb-256gb");

            link.Add("HP14SDK0117AU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=duoi-10-trieu&ram=4-gb&cpu=amd-ryzen-3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat ");
            link.Add("HP14SDK0132AU", "https://www.nguyenkim.com/hp-14s-dk0132au-amd-r5-3500u-14-inch-9av94pa.html");
            link.Add("HP14SDK1055AU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=duoi-10-trieu&ram=4-gb&cpu=amd-ryzen-3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat ");
            link.Add("HP14SDK1062AU", "https://fptshop.com.vn/may-tinh-xach-tay/hp-14s-dk1062au-r3-3250u");
            link.Add("HP14SDQ1022TU", "https://www.nguyenkim.com/laptop-hp-14s-dq1022tu-8qn41pa.html");
            link.Add("HP15DA0037TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp-15-da0037tx-i3-7020U");
            link.Add("HP15SDU0054TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat ");
            link.Add("HP15SDU0126TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HP15SDU1037TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HP15SDU1040TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp-15s-du1040tx-i7-10510u");
            link.Add("HP15SFQ1021TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HP15SFQ1107TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HP15SFQ1109TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HP15SFQ1116TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp-15s-fq1116tu-i3-1005g1");
            link.Add("HP348G5", "https://www.nguyenkim.com/laptop-hp-348-g5-7xu21pa.html");
            link.Add("HP348G7", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPNOTEBOOK14SDQ1020TU", "https://www.nguyenkim.com/hp-notebook-14s-dq1020tu-i5-1035g1-14-inch-8qn33pa.html");
            link.Add("HPPAVILION14CE3015TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPPAVILION14CE1014TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION14CE2036TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION14CE2039TU", "https://www.nguyenkim.com/laptop-hp-pavilion-14-ce2039tu.html");
            link.Add("HPPAVILION14CE2040TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp-pavilion-14-ce2040tu-core-i5-8265u");
            link.Add("HPPAVILION14CE3018TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp-pavilion-14-ce3018tu-i5-1035g");
            link.Add("HPPAVILION14CE3026TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS0016TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS1045TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS2001TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS2031TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS2033TU", "https://www.nguyenkim.com/laptop-hp-pavilion-15-cs2033tu-6yz14pa-xam.html");
            link.Add("HPPAVILION15CS2035TU", "https://www.nguyenkim.com/laptop-hp-pavilion-15-cs2035tu-6yz08pa.html");
            link.Add("HPPAVILION15CS2056TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=4-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS3008TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS3011TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS3060TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILION15CS3116TX", "https://fptshop.com.vn/may-tinh-xach-tay/hp-pavilion-15-cs3116tx-i5-1035g");
            link.Add("HPPAVILIONX36014CD1018TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILIONX36014DH0103TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILIONX36014DH1137TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPPAVILIONX36014DH1138TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("HPPAVILIONX36014DW0061TU", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPPROBOOK440G7", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&tinh-nang-dac-biet=o-cung-ssd&sort=ban-chay-nhat");
            link.Add("HPPROBOOK440G7I5", "https://fptshop.com.vn/may-tinh-xach-tay/hp?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");

            link.Add("LENOVOIDEAPAD33015IKB", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=duoi-10-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADC34014API", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideadpad-c340-14api-r5-3500u");
            link.Add("LENOVOIDEAPADC34014APIR7", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-c340-14api-r7-3700u");
            link.Add("LENOVOIDEAPADL34015IRH", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-l340-15irh-i5-9300h");
            link.Add("LENOVOIDEAPADL34015IRHI7", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-l340-15irh-i7-9750h");
            link.Add("LENOVOIDEAPADS14515API", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADS14515API8GB", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s145-15api-r5-3500u-8-512gb");
            link.Add("LENOVOIDEAPADS14515IIL", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s145-15iil-i5-1035g");
            link.Add("LENOVOIDEAPADS14515IIL8GB", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s145-15iil-i5-1035g1");
            link.Add("LENOVOIDEAPADS14515IKB", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=duoi-10-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADS340", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADS34014IIL", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADS34014IILI5", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s340-14iil-i5-1035g");
            link.Add("LENOVOIDEAPADS34015API", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=amd-ryzen-5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("LENOVOIDEAPADS34015IWL", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s340-15iwl-core-i3-8145u");
            link.Add("LENOVOIDEAPADS34015IWLI5", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-ideapad-s340-15iwl-i5-8265u");
            link.Add("LENOVOLEGION515ARH05", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-legion-5-15arh05-r5-4600h");
            link.Add("LENOVOLEGIONY54015IRH", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-legion-y540-15irh-i5-9300h");
            link.Add("LENOVOTHINKBOOK14", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-10-15-trieu&ram=4-gb&cpu=intel-core-i3&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("LENOVOTHINKBOOK14IIL", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("LENOVOTHINKBOOK15", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo-thinkbook-15-i5-10210u");
            link.Add("LENOVOTHINKPADE14", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");
            link.Add("LENOVOTHINKPADE490", "https://fptshop.com.vn/may-tinh-xach-tay/lenovo?muc-gia=tu-15-20-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-14-inch&sort=ban-chay-nhat");

            link.Add("MACBOOKAIR132019", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-air-13-256gb-2019");
            link.Add("MACBOOKAIR132020256GB", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-air-13-2020-1-1ghz-core-i3-8gb-256gb");
            link.Add("MACBOOKAIR132020512GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKAIR13MQD32SA", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-air-13-128gb-mqd32saa");
            link.Add("MACBOOKPRO13202014GHZ256GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO13202014GHZ512GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO13202020GHZ1TB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=16-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO13202020GHZ512GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=16-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO13TOUCHBAR128GB", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-pro-13-touch-bar-i5-1-4-ghz-8g-128gb-2019");
            link.Add("MACBOOKPRO13TOUCHBAR256GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO13TOUCHBAR512GB", "https://fptshop.com.vn/may-tinh-xach-tay/apple-macbook?muc-gia=tren-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=khoang-13-inch&sort=ban-chay-nhat");
            link.Add("MACBOOKPRO16TOUCHBARCOREI9", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-pro-16-touch-bar-23ghz-core-i9");
            link.Add("MACBOOKPRO16TOUCHBARCOREI7", "https://fptshop.com.vn/may-tinh-xach-tay/macbook-pro-16-touch-bar-26ghz-core-i7");
            link.Add("MSIALPHA15A3DDK", "https://fptshop.com.vn/may-tinh-xach-tay/msi-alpha-15-a3ddk-r7-3750h");
            link.Add("MSIBRAVO15A4DCR070VN", "https://fptshop.com.vn/may-tinh-xach-tay/msi-bravo-15-a4dcr-070vn-r5-4600h");
            link.Add("MSIGF638RC203VN", "https://fptshop.com.vn/may-tinh-xach-tay/msi-gf63-8rc-230vn-i5-8300h");
            link.Add("MSIGF639SC070VN", "https://www.nguyenkim.com/laptop-msi-gf63-9sc-070vn.html");
            link.Add("MSIGF639SC400VN", "https://fptshop.com.vn/may-tinh-xach-tay/msi-gf63-9sc-400vn-core-i5-9300h");
            link.Add("MSIGF639SCXR", "https://fptshop.com.vn/may-tinh-xach-tay/msi?muc-gia=tu-20-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("MSIGF639SCXR075VN", "https://fptshop.com.vn/may-tinh-xach-tay/msi?muc-gia=tu-20-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("MSIGF63THIN10SCXR427VN", "https://fptshop.com.vn/may-tinh-xach-tay/msi?muc-gia=tu-20-25-trieu&ram=8-gb&cpu=intel-core-i5&kich-thuoc-man-hinh=tren-15-inch&sort=ban-chay-nhat");
            link.Add("MSIGS659SD", "https://fptshop.com.vn/may-tinh-xach-tay/msi-gs65-9sd-i5-9300h-gtx1660ti");
            link.Add("MSIMODERN14A10M", "https://fptshop.com.vn/may-tinh-xach-tay/msi-modern-14-a10m-i5-10210u");
            link.Add("MSIMODERN15A10M", "https://fptshop.com.vn/may-tinh-xach-tay/msi-modern-15-a10m-i7-10510u");


            link.Add("ACERAPIREA3155434U1O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-a315-54-34u-i3-10110u/3994044-htm");
            link.Add("ACERASPIRE3A31554K37B0O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-3-a315-54k-37b0-i3-8130u/3745356-htm");
            link.Add("ACERASPIRE3A3155637DVO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-3-a315-56-37dv-i3-1005g1/4057029-htm");
            link.Add("ACERASPIRE3A3155659XYO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-3-a315-56-59xy-i5-1035g1/4057030-htm");
            link.Add("ACERASPIREA31542R4XDO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-a315-42-r4xd-r5-3500u/4057024-htm");
            link.Add("ACERASPIREA5155436H3O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-aspire-a515-54-36h3-core-i3-8145u/3019242-htm");
            link.Add("ACERSWIFTSF31456596EO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/acer-swift-sf314-56-596e-core-i5-8265u/3741437-htm");
            link.Add("ASUSA412FAEK740TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-a412fa-ek740t-i5-10210u/3727821-htm");
            link.Add("ASUSF571GTBQ532TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-f571gt-bq532t-i5-8300h/3897304-htm");
            link.Add("ASUSVIVOBOOKA412DAEK160TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivibook-a412da-ek160t-r5-3500u/3428322-htm");
            link.Add("ASUSVIVOBOOKA412DAEK347TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-a412da-ek347t-r3-3200u-htm");
            link.Add("ASUSVIVOBOOKA412FAEK380TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-a412fa-ek380t-core-i3-8145u-htm");
            link.Add("ASUSVIVOBOOKA512FLEJ251TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-a512fl-ej251t-i5-8265u/3442262-htm");
            link.Add("ASUSVIVOBOOKA512FLEJ507TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-a512fl-ej507t-core-i5-8265u/3991443-htm");
            link.Add("ASUSVIVOBOOKD509DAEJ448TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-d509da-ej448t-r3-3200u-htm");
            link.Add("ASUSVIVOBOOKFLIPTP412FAEC122TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-flip-tp412fa-ec122t-i5-8265u/3990888-htm");
            link.Add("ASUSVIVOBOOKX407UABV537TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x407ua-bv537t-core-i3-7020u-htm");
            link.Add("ASUSVIVOBOOKX409FAEK098TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x409fa-ek098t-i3-8145u-htm");
            link.Add("ASUSVIVOBOOKX507UAEJ234TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x507ua-ej234t-core-i3-7020u-htm	");
            link.Add("ASUSVIVOBOOKX509FAEJ560TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509fa-ej560t-i5-8265u-htm");
            link.Add("ASUSVIVOBOOKX509FJEJ225TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509fj-ej225t-core-i5-8265u-htm");
            link.Add("ASUSVIVOBOOKX509FJEJ314TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509fj-ej314t-i5-8265u-htm");
            link.Add("ASUSVIVOBOOKX509JAEJ171TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509ja-ej171t-i5-1035g1/3796770-htm");
            link.Add("ASUSVIVOBOOKX509UABR011TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509ua-br011t-core-i3-7020u-htm");
            link.Add("ASUSVIVOBOOKX509UABR236TO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/asus-vivobook-x509ua-br236t-core-i3-7020u-htm	");
            link.Add("DELLINSPIRONN3476BO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3476-core-i5-8250u-4gb-1tb-amd-520-radeon-2gb-htm");
            link.Add("DELLINSPIRONN3481UHDO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3481-core-i3-7020u-030cx1-htm");
            link.Add("DELLINSPIRONN3481O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3481-core-i3-7020u-70187649-htm");
            link.Add("DELLINSPIRONN3493O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3493-i3-1005g1/3866476-htm");
            link.Add("DELLINSPIRONN3580O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3580-core-i5-8265u-htm");
            link.Add("DELLINSPIRONN3581O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n3581-core-i3-7020u-htm");
            link.Add("DELLINSPIRONN5584O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n5584-core-i5-8265u-htm");
            link.Add("DELLINSPIRONN5593O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n5593-i3-1005g1/3796815-htm");
            link.Add("DELLINSPIRONN559I5O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-inspiron-n5593-i5-1035g1-8gb-512gb/4056935-htm");
            link.Add("DELLVOSTROV3490O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-v3490-i5-10210u-htm");
            link.Add("DELLVOSTROV3590O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-v3590-i3-10110u-4gb-256gb/3991067-htm");
            link.Add("DELLVOSTROV5481O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-5481-core-i5-8265u-1tb-v4i5229w-htm");
            link.Add("DELLVOSTROV5490O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-v5490-i3-10110u/4001062-htm");
            link.Add("DELLVOSTROV5581O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-v5581-core-i5-8265u-finger-70194504-htm");
            link.Add("DELLVOSTROV5590O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/dell-vostro-v5590-i5-10210u/3961150-htm");
            link.Add("HP14SDK0117AUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-14s-dk0117au-r3-3200u-htm");
            link.Add("HP15DA0037TXO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-15-da0037tx-i3-7020U-htm");
            link.Add("HP15SDU0126TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-15s-du0126tu-i3-8130u-htm");
            link.Add("HP15SDU1040TXO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-15s-du1040tx-i7-10510u/3993987-htm");
            link.Add("HPPAVILION14CE3015TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-14-ce3015tu-i3-1005g1-htm");
            link.Add("HPPAVILION14CE2040TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-14-ce2040tu-core-i5-8265u-htm");
            link.Add("HPPAVILION15CS0016TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-15-cs0016tu/3736630-htm");
            link.Add("HPPAVILION15CS2056TXO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-15-cs2056tx-i5-8265u/3779462-htm");
            link.Add("HPPAVILION15CS3008TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-15-cs3008tu-i3-1005g-htm");
            link.Add("HPPAVILION15CS3011TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-15-cs3011tu-i5-1035g-htm");
            link.Add("HPPAVILION15CS3116TXO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-15-cs3116tx-i5-1035g-htm");
            link.Add("HPPAVILIONX36014CD1018TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-x360-14-cd1018tu-core-i3-8145u/3993030-htm");
            link.Add("HPPAVILIONX36014DH1137TUO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-pavilion-x360-14-dh1137tu-i3-10110u/3895137-htm");
            link.Add("HPPROBOOK440G7O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/hp-probook-440-g7-i3-10110u/3970895-htm");
            link.Add("LENOVOIDEAPAD33015IKBO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/lenovo-ideapad-330-15ikb-core-i3-7020u-htm");
            link.Add("LENOVOIDEAPADS14514IKBO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/lenovo-ideapad-s145-14ikb-i3-8130u-htm");
            link.Add("LENOVOIDEAPADS340O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/lenovo-ideapad-s340-r5-3500u-htm");
            link.Add("LENOVOIDEAPADS34015IWLO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/lenovo-ideapad-s340-15iwl-core-i3-8145u-htm");
            link.Add("LENOVOIDEAPADS34015IWLI5O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/lenovo-ideapad-s340-15iwl-i5-8265u/3979225-htm");
            link.Add("MACBOOKAIR132019O", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/macbook-air-13-256gb-2019/2454377-htm");
            link.Add("MACBOOKAIR13MQD32SAO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/macbook-air-13-128gb-mqd32saa/3970397-htm");
            link.Add("MACBOOKPRO13TOUCHBAR128GBO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/macbook-pro-13-touch-bar-i5-1-4-ghz-8g-128gb-2019/3894264-htm");
            link.Add("MACBOOKPRO13TOUCHBAR256GBO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/macbook-pro-13-touch-bar-i5-1-4-ghz-8g-256gb-2019/3600051-htm");
            link.Add("MACBOOKPRO13TOUCHBAR512GBO", "https://fptshop.com.vn/may-doi-tra/may-tinh-xach-tay-cu-gia-re/macbook-pro-13-inch-touch-bar-512gb-2017/3088777-htm");

            link.Add("NONE", "404 not found");
        }

        public FormQuestion()
        {
            InitializeComponent();
            prolog = new MyProlog();
            prolog.LoadFile(prologFilePath);
            // Build List question
            buildListQuestion();
            BuildDescription();
            BuildImage();
            BuildLink();
        }

        private void buildListQuestion()
        {
            // 0
            questionList.Add(new MyQuestion("Label?",
                new List<string>() { "New", "Old" }));
            // 1
            questionList.Add(new MyQuestion("Class?",
                new List<string>() { "Common", "Luxury" }));
            // 2
            questionList.Add(new MyQuestion("Brand?",
                new List<string>() { "Asus", "Acer", "Dell", "HP", "Lenovo" }));

            // 3
            questionList.Add(new MyQuestion("Brand?",
                 new List<string>() { "Macbook", "MSI" }));
            // 4
            questionList.Add(new MyQuestion("Price?",
                new List<string>() { "Less than 10m", "10-15m", "15-20m", "Whatever" }));
            // 5
            questionList.Add(new MyQuestion("Price?",
                new List<string>() { "Less than 20m", "20-30m", "Greater than 30m", "Whatever" }));
            // 6
            questionList.Add(new MyQuestion("RAM?",
                new List<string>() { "4Gb", "8Gb", "Whatever" }));
            // 7
            questionList.Add(new MyQuestion("RAM?",
                new List<string>() { "8Gb", "16Gb", "Whatever" }));
            // 8
            questionList.Add(new MyQuestion("CPU?",
                new List<string>() { "Core i3", "Core i5", "Core i7", "Core i9", "Ryzen 3", "Ryzen 5", "Ryzen 7", "Whatever" }));
            // 9
            questionList.Add(new MyQuestion("Hardware?",
                new List<string>() { "SSD", "HDD", "Whatever" }));
            // 10
            questionList.Add(new MyQuestion("Diskspace?",
                new List<string>() { "128Gb", "256Gb", "512Gb", "1Tb", "Whatever" }));
            // 11
            questionList.Add(new MyQuestion("Screen Size?",
                new List<string>() { "13.3", "14", "15.6", "16" }));
            // 12
            questionList.Add(new MyQuestion("GPU?",
                new List<string>() { "Intel UHD", "Intel HD", "AMD", "NVIDIA", "Intel Iris Plus" }));
        }

        private void BindQuestion(int index)
        {
            HideRadioButton();
            lbQuestion.Text = questionList[index].Question;
            for (int i = 0; i < questionList[index].Answers.Count; i++)
            {
                RadioButton c = (RadioButton)this.Controls.Find("rd" + (i + 1), true).FirstOrDefault();
                c.Text = questionList[index].Answers[i];
                c.Visible = true;
            }
        }

        private int QuestionControl(int index, String ans)
        {
            int current = -1;
            switch (index)
            {
                case 0:
                    if (ans.Equals("new") || ans.Equals("old")) { BindQuestion(1); current = 1; }
                    break;
                case 1:
                    if (ans.Equals("common")) { BindQuestion(2); current = 2; }
                    else if (ans.Equals("luxury")) { BindQuestion(3); current = 3; }
                    break;
                case 2:
                    if (ans.Equals("asus") || ans.Equals("acer") || ans.Equals("dell") || ans.Equals("hp") || ans.Equals("lenovo"))
                    { BindQuestion(4); current = 4; }
                    break;
                case 3:
                    if (ans.Equals("macbook") || ans.Equals("msi"))
                    { BindQuestion(5); current = 5; }
                    break;
                case 4:
                    if (ans.Equals("less_than_10m") || ans.Equals("10_15m") || ans.Equals("15_20m"))
                    { BindQuestion(6); current = 6; }
                    break;
                case 5:
                    if (ans.Equals("less_than_20m") || ans.Equals("20_30m") || ans.Equals("greater_than_30m"))
                    { BindQuestion(7); current = 7; }
                    break;
                case 6:
                    if (ans.Equals("4gb") || ans.Equals("8gb"))
                    { BindQuestion(8); current = 8; }
                    break;
                case 7:
                    if (ans.Equals("8gb") || ans.Equals("16gb"))
                    { BindQuestion(8); current = 8; }
                    break;
                case 8:
                    if (ans.Equals("core_i3") || ans.Equals("core_i5") || ans.Equals("core_i7") || ans.Equals("core_i9") || ans.Equals("ryzen_3") || ans.Equals("ryzen_5") || ans.Equals("ryzen_7"))
                    { BindQuestion(9); current = 9; }
                    break;
                case 9:
                    if (ans.Equals("ssd") || ans.Equals("hdd")) { BindQuestion(10); current = 10; }
                    break;
                case 10:
                    if (ans.Equals("128gb") || ans.Equals("256gb") || ans.Equals("512gb") || ans.Equals("1tb")) 
                        { BindQuestion(11); current = 11; }
                    break;
                case 11:
                    if (ans.Equals("14") || ans.Equals("15.6") || ans.Equals("13.3") || ans.Equals("16"))
                    { BindQuestion(12); current = 12; }
                    break;
                case 12:
                    //if (ans.Equals("intel_uhd") || ans.Equals("intel_hd") || ans.Equals("amd") || ans.Equals("nvidia") || ans.Equals("intel_iris_plus"))
                    //{ BindQuestion(13); current = 13; }
                    break;
            }
            return current;
        }

        private String GetResult(String ans)
        {
            return ans.Replace(" ", "_").Replace("-", "_").ToLower();
        }

        private void HideRadioButton()
        {
            rd1.Visible = false;
            rd2.Visible = false;
            rd3.Visible = false;
            rd4.Visible = false;
            rd5.Visible = false;
            rd6.Visible = false;
            rd7.Visible = false;
            rd8.Visible = false;
        }

        private void reset()
        {
            btnStart.Visible = true;
            pnlQuestion.Visible = false;
            myAnswers.Clear();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            pnlQuestion.Visible = true;
            currentQuestion = 0;
            BindQuestion(0);
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rd1.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd1.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd1.Text)); }
            else if (rd2.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd2.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd2.Text)); rd1.Checked = true; }
            else if (rd3.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd3.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd3.Text)); rd1.Checked = true; }
            else if (rd4.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd4.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd4.Text)); rd1.Checked = true; }
            else if (rd5.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd5.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd5.Text)); rd1.Checked = true; }
            else if (rd6.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd6.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd6.Text)); rd1.Checked = true; }
            else if (rd7.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd7.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd7.Text)); rd1.Checked = true; }
            else if (rd8.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd8.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd8.Text)); rd1.Checked = true; }
            //else if (rd9.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd9.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd9.Text)); }
            if (currentQuestion == -1)
            {
                GlobalVariable.history = "";
                GlobalVariable.Image = "";
                GlobalVariable.Link = "";
                String query = "";
                while (myAnswers.Count > 0)
                {
                    MyAnswer ma = myAnswers.Pop();
                    query = key[ma.QuestionIndex] + "('" + ma.Answer + "'), " + query;
                    GlobalVariable.history = "---------------------------------------------------\r\n" + GlobalVariable.history;
                    GlobalVariable.history = "[A] " + ma.Answer + "\r\n" + GlobalVariable.history;
                    GlobalVariable.history = "[Q] " + questionList[ma.QuestionIndex].Question + "\r\n" + GlobalVariable.history;
                }
                query = query.Substring(0, query.Length - 2);
                query = "laptop(X, " + query + ").";
                try
                {
                    if (prolog.GetResult(query) == "")
                    {
                        GlobalVariable.history = "Nothing";
                        GlobalVariable.result = "Nothing";
                        GlobalVariable.Image = "C:\\UIT\\AI\\Final\\Final\\RecourcesImage\\notfound.png";
                        GlobalVariable.Link = "Nothing";
                        MessageBox.Show("Sorry!!! \r\n No result !!!", "Oopss!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else if (prolog.GetResult(query).ToUpper() != "NONE")
                    {
                        GlobalVariable.result = description[prolog.GetResult(query).ToUpper()];
                        GlobalVariable.Image = image[prolog.GetResult(query).ToUpper()];
                        GlobalVariable.Link = link[prolog.GetResult(query).ToUpper()];
                        //new FormResult(GlobalVariable.result, GlobalVariable.Image);
                        //String Link = link[prolog.GetResult(query).ToUpper()];
                        //new Form2(result, Link, "Bingo!!!").ShowDialog();
                       
                        MessageBox.Show("Done!!! \r\n Please check Result !!!", "Bingo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        GlobalVariable.history = "Nothing";
                        GlobalVariable.result = description[prolog.GetResult(query).ToUpper()];
                        GlobalVariable.Image = image[prolog.GetResult(query).ToUpper()];
                        GlobalVariable.Link = link[prolog.GetResult(query).ToUpper()];
                        MessageBox.Show("Sorry!!! \r\n No result !!!", "Oopss!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                reset();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (myAnswers.Count > 0)
            {
                currentQuestion = myAnswers.Peek().QuestionIndex;
                BindQuestion(currentQuestion);
                myAnswers.Pop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd1.Top - 3; }
        private void rd2_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd2.Top - 3; }
        private void rd3_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd3.Top - 3; }
        private void rd4_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd4.Top - 3; }
        private void rd5_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd5.Top - 3; }
        private void rd6_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd6.Top - 3; }
        private void rd7_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd7.Top - 3; }
        private void rd8_CheckedChanged(object sender, EventArgs e){ pnlLeft.Top = rd8.Top - 3; }
    }
}
