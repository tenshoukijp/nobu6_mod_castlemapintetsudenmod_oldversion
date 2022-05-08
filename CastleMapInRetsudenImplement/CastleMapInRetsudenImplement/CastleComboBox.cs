using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;



partial class CastleMapInRetsudenViewerImplement : Form
{
    ComboBox CastleListComboBox;  // コンボボックス


    void AddCastleList()
    {
        CastleListComboBox.BeginUpdate();
        // 項目の追加
        CastleListComboBox.Items.Add("000:金石城");
        CastleListComboBox.Items.Add("001:七尾城");
        CastleListComboBox.Items.Add("002:指月城");
        CastleListComboBox.Items.Add("003:益田城");
        CastleListComboBox.Items.Add("004:神西城");
        CastleListComboBox.Items.Add("005:白鹿城");
        CastleListComboBox.Items.Add("006:尾山御坊");
        CastleListComboBox.Items.Add("007:湊城");
        CastleListComboBox.Items.Add("008:桧山城");
        CastleListComboBox.Items.Add("009:徳山館");
        CastleListComboBox.Items.Add("010:平戸城");
        CastleListComboBox.Items.Add("011:門司城");
        CastleListComboBox.Items.Add("012:三本松城");
        CastleListComboBox.Items.Add("013:山吹城");
        CastleListComboBox.Items.Add("014:月山富田城");
        CastleListComboBox.Items.Add("015:北ノ庄城");
        CastleListComboBox.Items.Add("016:大聖寺城");
        CastleListComboBox.Items.Add("017:雑太城");
        CastleListComboBox.Items.Add("018:尾浦城");
        CastleListComboBox.Items.Add("019:鮭延城");
        CastleListComboBox.Items.Add("020:石川城");
        CastleListComboBox.Items.Add("021:立花山城");
        CastleListComboBox.Items.Add("022:且山城");
        CastleListComboBox.Items.Add("023:尾高城");
        CastleListComboBox.Items.Add("024:八橋城");
        CastleListComboBox.Items.Add("025:増山城");
        CastleListComboBox.Items.Add("026:本庄城");
        CastleListComboBox.Items.Add("027:山形城");
        CastleListComboBox.Items.Add("028:横手城");
        CastleListComboBox.Items.Add("029:角館城");
        CastleListComboBox.Items.Add("030:浪岡城");
        CastleListComboBox.Items.Add("031:勢福寺城");
        CastleListComboBox.Items.Add("032:岩屋城");
        CastleListComboBox.Items.Add("033:城井谷城");
        CastleListComboBox.Items.Add("034:高嶺城");
        CastleListComboBox.Items.Add("035:瀬戸山城");
        CastleListComboBox.Items.Add("036:羽衣石城");
        CastleListComboBox.Items.Add("037:鳥取城");
        CastleListComboBox.Items.Add("038:府中城");
        CastleListComboBox.Items.Add("039:一乗谷城");
        CastleListComboBox.Items.Add("040:富山城");
        CastleListComboBox.Items.Add("041:与板城");
        CastleListComboBox.Items.Add("042:水ヶ江城");
        CastleListComboBox.Items.Add("043:富田若山城");
        CastleListComboBox.Items.Add("044:小倉山城");
        CastleListComboBox.Items.Add("045:高田城");
        CastleListComboBox.Items.Add("046:宮津城");
        CastleListComboBox.Items.Add("047:魚津城");
        CastleListComboBox.Items.Add("048:琵琶島城");
        CastleListComboBox.Items.Add("049:新発田城");
        CastleListComboBox.Items.Add("050:米沢城");
        CastleListComboBox.Items.Add("051:名生城");
        CastleListComboBox.Items.Add("052:不来方城");
        CastleListComboBox.Items.Add("053:三戸城");
        CastleListComboBox.Items.Add("054:蒲池城");
        CastleListComboBox.Items.Add("055:古処山城");
        CastleListComboBox.Items.Add("056:吉田郡山城");
        CastleListComboBox.Items.Add("057:林野城");
        CastleListComboBox.Items.Add("058:若桜鬼ヶ城");
        CastleListComboBox.Items.Add("059:此隅城");
        CastleListComboBox.Items.Add("060:建部山城");
        CastleListComboBox.Items.Add("061:後瀬山城");
        CastleListComboBox.Items.Add("062:金ヶ崎城");
        CastleListComboBox.Items.Add("063:春日山城");
        CastleListComboBox.Items.Add("064:栃尾城");
        CastleListComboBox.Items.Add("065:津川城");
        CastleListComboBox.Items.Add("066:黒川城");
        CastleListComboBox.Items.Add("067:白石城");
        CastleListComboBox.Items.Add("068:寺池城");
        CastleListComboBox.Items.Add("069:高水寺城");
        CastleListComboBox.Items.Add("070:九戸城");
        CastleListComboBox.Items.Add("071:三城");
        CastleListComboBox.Items.Add("072:府内城");
        CastleListComboBox.Items.Add("073:鞍掛山城");
        CastleListComboBox.Items.Add("074:佐東銀山城");
        CastleListComboBox.Items.Add("075:鶴首城");
        CastleListComboBox.Items.Add("076:松倉城");
        CastleListComboBox.Items.Add("077:坂戸城");
        CastleListComboBox.Items.Add("078:二本松城");
        CastleListComboBox.Items.Add("079:日野江城");
        CastleListComboBox.Items.Add("080:岡城");
        CastleListComboBox.Items.Add("081:古高山城");
        CastleListComboBox.Items.Add("082:天神山城");
        CastleListComboBox.Items.Add("083:上月城");
        CastleListComboBox.Items.Add("084:竹田城");
        CastleListComboBox.Items.Add("085:横山城");
        CastleListComboBox.Items.Add("086:大溝城");
        CastleListComboBox.Items.Add("087:小谷城");
        CastleListComboBox.Items.Add("088:郡上八幡城");
        CastleListComboBox.Items.Add("089:飯山城");
        CastleListComboBox.Items.Add("090:須賀川城");
        CastleListComboBox.Items.Add("091:隈府城");
        CastleListComboBox.Items.Add("092:丹生島城");
        CastleListComboBox.Items.Add("093:三原城");
        CastleListComboBox.Items.Add("094:猿掛城");
        CastleListComboBox.Items.Add("095:沼田城");
        CastleListComboBox.Items.Add("096:三春城");
        CastleListComboBox.Items.Add("097:小高城");
        CastleListComboBox.Items.Add("098:内牧城");
        CastleListComboBox.Items.Add("099:来島城");
        CastleListComboBox.Items.Add("100:神辺城");
        CastleListComboBox.Items.Add("101:岡山城");
        CastleListComboBox.Items.Add("102:砥石城");
        CastleListComboBox.Items.Add("103:八上城");
        CastleListComboBox.Items.Add("104:上平寺城");
        CastleListComboBox.Items.Add("105:大垣城");
        CastleListComboBox.Items.Add("106:川手城");
        CastleListComboBox.Items.Add("107:林城");
        CastleListComboBox.Items.Add("108:葛尾城");
        CastleListComboBox.Items.Add("109:志賀城");
        CastleListComboBox.Items.Add("110:宇都宮城");
        CastleListComboBox.Items.Add("111:烏山城");
        CastleListComboBox.Items.Add("112:小峰城");
        CastleListComboBox.Items.Add("113:古麓城");
        CastleListComboBox.Items.Add("114:栂牟礼城");
        CastleListComboBox.Items.Add("115:大洲城");
        CastleListComboBox.Items.Add("116:姫路城");
        CastleListComboBox.Items.Add("117:坂本城");
        CastleListComboBox.Items.Add("118:厩橋城");
        CastleListComboBox.Items.Add("119:唐沢山城");
        CastleListComboBox.Items.Add("120:大館城");
        CastleListComboBox.Items.Add("121:水俣城");
        CastleListComboBox.Items.Add("122:湯築城");
        CastleListComboBox.Items.Add("123:仏殿城");
        CastleListComboBox.Items.Add("124:天霧城");
        CastleListComboBox.Items.Add("125:三木城");
        CastleListComboBox.Items.Add("126:丹波亀山城");
        CastleListComboBox.Items.Add("127:室町御所");
        CastleListComboBox.Items.Add("128:佐和山城");
        CastleListComboBox.Items.Add("129:犬山城");
        CastleListComboBox.Items.Add("130:上原城");
        CastleListComboBox.Items.Add("131:箕輪城");
        CastleListComboBox.Items.Add("132:小山城");
        CastleListComboBox.Items.Add("133:人吉城");
        CastleListComboBox.Items.Add("134:門川城");
        CastleListComboBox.Items.Add("135:松葉城");
        CastleListComboBox.Items.Add("136:観音寺城");
        CastleListComboBox.Items.Add("137:岩村城");
        CastleListComboBox.Items.Add("138:木曾福島城");
        CastleListComboBox.Items.Add("139:平井城");
        CastleListComboBox.Items.Add("140:忍城");
        CastleListComboBox.Items.Add("141:結城城");
        CastleListComboBox.Items.Add("142:太田城");
        CastleListComboBox.Items.Add("143:出水城");
        CastleListComboBox.Items.Add("144:本山城");
        CastleListComboBox.Items.Add("145:白地城");
        CastleListComboBox.Items.Add("146:十河城");
        CastleListComboBox.Items.Add("147:伊丹城");
        CastleListComboBox.Items.Add("148:勝龍寺城");
        CastleListComboBox.Items.Add("149:清洲城");
        CastleListComboBox.Items.Add("150:高遠城");
        CastleListComboBox.Items.Add("151:古河城");
        CastleListComboBox.Items.Add("152:飯野城");
        CastleListComboBox.Items.Add("153:都於郡城");
        CastleListComboBox.Items.Add("154:中村城");
        CastleListComboBox.Items.Add("155:山科本願寺");
        CastleListComboBox.Items.Add("156:水口城");
        CastleListComboBox.Items.Add("157:長島願証寺");
        CastleListComboBox.Items.Add("158:躑躅ヶ崎館");
        CastleListComboBox.Items.Add("159:松山城");
        CastleListComboBox.Items.Add("160:河越城");
        CastleListComboBox.Items.Add("161:小田城");
        CastleListComboBox.Items.Add("162:水戸城");
        CastleListComboBox.Items.Add("163:一宇治城");
        CastleListComboBox.Items.Add("164:岡豊城");
        CastleListComboBox.Items.Add("165:勝瑞城");
        CastleListComboBox.Items.Add("166:洲本城");
        CastleListComboBox.Items.Add("167:石山本願寺");
        CastleListComboBox.Items.Add("168:芥川城");
        CastleListComboBox.Items.Add("169:多聞山城");
        CastleListComboBox.Items.Add("170:那古野城");
        CastleListComboBox.Items.Add("171:飯田城");
        CastleListComboBox.Items.Add("172:岩殿山城");
        CastleListComboBox.Items.Add("173:岩付城");
        CastleListComboBox.Items.Add("174:加治木城");
        CastleListComboBox.Items.Add("175:飫肥城");
        CastleListComboBox.Items.Add("176:窪川城");
        CastleListComboBox.Items.Add("177:上野城");
        CastleListComboBox.Items.Add("178:伊勢亀山城");
        CastleListComboBox.Items.Add("179:滝山城");
        CastleListComboBox.Items.Add("180:江戸城");
        CastleListComboBox.Items.Add("181:土浦城");
        CastleListComboBox.Items.Add("182:清水城");
        CastleListComboBox.Items.Add("183:安芸城");
        CastleListComboBox.Items.Add("184:牛岐城");
        CastleListComboBox.Items.Add("185:堺");
        CastleListComboBox.Items.Add("186:若江城");
        CastleListComboBox.Items.Add("187:筒井城");
        CastleListComboBox.Items.Add("188:鳴海城");
        CastleListComboBox.Items.Add("189:長篠城");
        CastleListComboBox.Items.Add("190:玉縄城");
        CastleListComboBox.Items.Add("191:垂水城");
        CastleListComboBox.Items.Add("192:海部城");
        CastleListComboBox.Items.Add("193:岸和田城");
        CastleListComboBox.Items.Add("194:安濃津城");
        CastleListComboBox.Items.Add("195:二俣城");
        CastleListComboBox.Items.Add("196:興国寺城");
        CastleListComboBox.Items.Add("197:小田原城");
        CastleListComboBox.Items.Add("198:千葉城");
        CastleListComboBox.Items.Add("199:肝付城");
        CastleListComboBox.Items.Add("200:高屋城");
        CastleListComboBox.Items.Add("201:信貴山城");
        CastleListComboBox.Items.Add("202:鳥羽城");
        CastleListComboBox.Items.Add("203:岡崎城");
        CastleListComboBox.Items.Add("204:韮山城");
        CastleListComboBox.Items.Add("205:種子島城");
        CastleListComboBox.Items.Add("206:岩室城");
        CastleListComboBox.Items.Add("207:吉田城");
        CastleListComboBox.Items.Add("208:曳馬城");
        CastleListComboBox.Items.Add("209:駿府城");
        CastleListComboBox.Items.Add("210:稲村城");
        CastleListComboBox.Items.Add("211:真里谷城");
        CastleListComboBox.Items.Add("212:高天神城");
        CastleListComboBox.Items.Add("213:手取城");
        CastleListComboBox.Items.Add("214:安土/大坂");

        CastleListComboBox.EndUpdate();
    }

    void SetAddComboBox()
    {
        // キャッスルリストをコンボボックスとして
        CastleListComboBox = new ComboBox()
        {
            Location = new Point(320, iTopStandingPos),
            DropDownStyle = ComboBoxStyle.DropDownList,  // 表示形式
        };

        // コンボボックスに城名リスト追加
        AddCastleList();

        // 最初に選択される項目
        CastleListComboBox.SelectedIndex = 0;

        // どれかを選択したらイベント駆動するように
        CastleListComboBox.SelectedIndexChanged += new EventHandler(CastleListComboBox_SelectedIndexChanged);

        // フォームにコンボボックス追加
        this.Controls.Add(CastleListComboBox);

    }

    int GetSelectedHexMapID()
    {
        // 安土城/大坂城は最後にくっついている
        if (CastleListComboBox.SelectedIndex == 214)
        {
            return 1594;
        }
        else
        {
            return CastleListComboBox.SelectedIndex + iHexmapCastleStartID;
        }
    }

    int GetSelectedRoleMapID()
    {
        // 安土城/大坂城は最後にくっついている
        if (CastleListComboBox.SelectedIndex == 214)
        {
            return 1595;
        }
        else
        {
            return GetSelectedHexMapID() + iCastleNum;
        }
    }

    int GetSelectedHighMapID()
    {
        // 安土城/大坂城は最後にくっついている
        if (CastleListComboBox.SelectedIndex == 214)
        {
            return 1596;
        }
        else
        {
            return GetSelectedHexMapID() + iCastleNum * 2;
        }
    }

    // 選択項目が変更されたときのイベントハンドラ
    void CastleListComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}
