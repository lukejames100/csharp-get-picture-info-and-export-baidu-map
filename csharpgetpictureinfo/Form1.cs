using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
//https://blog.csdn.net/daiafei/article/details/7395505
//https://www.cnblogs.com/xianyin05/archive/2013/05/10/3071373.html
namespace csharpgetpictureinfo
{
    public partial class Form1 : Form
    {
        private string filename;
        public int isgetjingweidu;
        public string gjingdu;
        public string gweidu;
        public Form1()
        {
            InitializeComponent();
        }
        public struct Metadatadetail
        {
            public string hex;//16进制字符串
            public string rawvalueasstring;//原始值串
            public string displayvalue;//显示值串
        }
        public struct metadata{
            public Metadatadetail equipmentmake;
            public Metadatadetail cameramodel;
            public Metadatadetail exposuretime;//曝光时间
            public Metadatadetail fstop;
            public Metadatadetail datepicturetaken;
            public Metadatadetail shutterspeed;//快门速度
            public Metadatadetail meteringmode;//曝光模式
            public Metadatadetail flash;//闪光灯
            public Metadatadetail xresolution;
            public Metadatadetail yresolution;
            public Metadatadetail imagewidth;//照片宽度
            public Metadatadetail imageheight;//照片高度
            public Metadatadetail fnumber;//f值，光圈数
            public Metadatadetail exposureprog;//曝光程序
            public Metadatadetail spectralsense;//
            public Metadatadetail isospeed;//iso感光度
            public Metadatadetail oecf;
            public Metadatadetail ver;//exif版本
            public Metadatadetail compconfig;//色彩设置
            public Metadatadetail compbpp;//压缩比率
            public Metadatadetail aperture;//光圈值
            public Metadatadetail brightness;//亮度值ev
            public Metadatadetail exposurebias;//曝光补偿
            public Metadatadetail maxaperture;//最大光圈值
            public Metadatadetail subjectdist;//主体距离
            public Metadatadetail lightsource;//白平衡
            public Metadatadetail focallength;//焦距
            public Metadatadetail fpxver;//flashpix版本
            public Metadatadetail colorspace;//色彩空间
            public Metadatadetail interop;
            public Metadatadetail flashenergy;
            public Metadatadetail spatialfr;
            public Metadatadetail focalxres;
            public Metadatadetail focalyres;
            public Metadatadetail focalresunit;
            public Metadatadetail exposureinde;//曝光指数
            public Metadatadetail sensingmethod;//感光方式
            public Metadatadetail scenetype;
            public Metadatadetail cfapattern;

            public Metadatadetail exififd;//0x8769
            public Metadatadetail gpsifd;//0x8825
            public Metadatadetail newsubfiletype;//0xfe
            public Metadatadetail subfiletype;//0xff
            public Metadatadetail imagewidth100;//0x100
            public Metadatadetail imageheight101;//0x101
            public Metadatadetail bitspersample;//0x102
            public Metadatadetail compressionn;//0x103
            public Metadatadetail photometricinterp;//0x106
            public Metadatadetail threshholding;//0x107
            public Metadatadetail cellwidth;//0x108
            public Metadatadetail cellheight;//0x109
            public Metadatadetail fillorder;//0x10a
            public Metadatadetail documentname;//0x10d;
            public Metadatadetail imagedescription;//0x10e
            public Metadatadetail stripoffsets;//0x111
            public Metadatadetail orientation;//0x112
            public Metadatadetail samplesperpixel;//0x115
            public Metadatadetail rowsperstrip;//0x116
            public Metadatadetail stripbytescount;//0x117
            public Metadatadetail minsamplevalue;//0x118
            public Metadatadetail maxsamplevalue;//0x119
            public Metadatadetail xresolution11a;//0x11a
            public Metadatadetail yresolution11b;//0x11b
            public Metadatadetail planarconfig;//0x11c
            public Metadatadetail pagename;//0x11d
            public Metadatadetail xposition;//0x11e
            public Metadatadetail yposition;//0x11f
            public Metadatadetail freeoffset;//0x120
            public Metadatadetail freebytecounts;//0x121
            public Metadatadetail grayresponseunit;//0x122
            public Metadatadetail grayresponsecurve;//0x123
            public Metadatadetail t4option;//0x124
            public Metadatadetail t6option;//0x125
            public Metadatadetail resolutionunit;//0x128
            public Metadatadetail pagenumber;//0x129
            public Metadatadetail transferfunctition;//0x12d
            public Metadatadetail softwareused;//0x131
            public Metadatadetail datetime;//0x132
            public Metadatadetail artist;//0x13b
            public Metadatadetail hostcomputer;//0x13c
            public Metadatadetail predictor;//0x13d
            public Metadatadetail whitepoint;//0x13e
            public Metadatadetail primarychromaticities;//0x13f
            public Metadatadetail colormap;//0x140
            public Metadatadetail halftonehints;//0x141
            public Metadatadetail tilewidth;//0x142
            public Metadatadetail tilelength;//0x143
            public Metadatadetail tileoffset;//0x144
            public Metadatadetail tilebytecounts;//0x145
            public Metadatadetail inkset;//0x14c
            public Metadatadetail inknames;//0x14d
            public Metadatadetail numberofinks;//0x14e
            public Metadatadetail dotrange;//0x150
            public Metadatadetail targetprinter;//0x151
            public Metadatadetail extrasamples;//0x152
            public Metadatadetail sampleformat;//0x153
            public Metadatadetail sminsamplevalue;//0x154
            public Metadatadetail smaxsamplevalue;//0x155
            public Metadatadetail transferrange;//0x156
            public Metadatadetail jpegproc;//0x200
            public Metadatadetail jpeginterformat;//0x201
            public Metadatadetail jpeginterlength;//0x202
            public Metadatadetail jpegrestartinterval;//0x203
            public Metadatadetail jpeglosslesspredictors;//0x205
            public Metadatadetail jpegpointtransforms;//0x206
            public Metadatadetail jpegqtables;//0x207
            public Metadatadetail jpegdctables;//0x208
            public Metadatadetail jpegactables;//0x209
            public Metadatadetail ycbcrcoefficients;//0x211
            public Metadatadetail ycbcrsubsampling;//0x212
            public Metadatadetail ycbcrpositioning;//0x213
            public Metadatadetail refblackwhite;//0x214
            public Metadatadetail iccprofile;//0x8773
            public Metadatadetail gamma;//0x301
            public Metadatadetail iccprofiledescriptor;//0x302
            public Metadatadetail srgbrenderingintent;//0x303
            public Metadatadetail imagetitle;//0x320
            public Metadatadetail copyright;//0x8298
            public Metadatadetail resolutionxunit;//0x5001
            public Metadatadetail resolutionyunit;//0x5002
            public Metadatadetail resolutionxlengthunit;//0x5003
            public Metadatadetail resolutionylengthunit;//0x5004
            public Metadatadetail printflags;//0x5005
            public Metadatadetail printflagsversion;//0x5006
            public Metadatadetail printflagscrop;//0x5007
            public Metadatadetail printflagsbleedwidth;//0x5008
            public Metadatadetail printflagsbleedwidthscale;//0x5009
            public Metadatadetail halftonelpi;//0x500a
            public Metadatadetail halftonelpiunit;//0x500b
            public Metadatadetail halftonedegree;//0x500c
            public Metadatadetail halftoneshape;//0x500d
            public Metadatadetail halftonemisc;//0x500e
            public Metadatadetail halftonescreen;//0x500f
            public Metadatadetail jpegquality;//0x5010
            public Metadatadetail gridsize;//0x5011
            public Metadatadetail thumbnailformat;//0x5012
            public Metadatadetail thumbnailwidth;//0x5013
            public Metadatadetail thumbnailheight;//0x5014
            public Metadatadetail thumbnailcolordepth;//0x5015
            public Metadatadetail thumbnailplanes;//0x5016
            public Metadatadetail thumbnailrawbytes;//0x5017
            public Metadatadetail thumbnailsize;//0x5018
            public Metadatadetail thumbnailcompressedsize;//0x5019
            public Metadatadetail colortransferfuntion;//0x501a
            public Metadatadetail thumbnaildata;//0x501b
            public Metadatadetail thumbnailimagewidth;//0x5020
            public Metadatadetail thumbnailimageheight;//0x5021
            public Metadatadetail thumbnailbitspersample;//0x5022
            public Metadatadetail thumbnailcompression;//0x5023
            public Metadatadetail thumbnailphotometricinterp;//0x5024
            public Metadatadetail thumbnailimagedescription;//0x5025
            public Metadatadetail thumbnailequipmake;//0x5026
            public Metadatadetail thumbnailequipmodel;//0x5027
            public Metadatadetail thumbnailstripoffsets;//0x5028
            public Metadatadetail thumbnailorientation;//0x5029
            public Metadatadetail thumbnailsamplesperpixel;//0x502a
            public Metadatadetail thumbnailrowsperstrip;//0x502b
            public Metadatadetail thumbnailstripbytescount;//0x502c
            public Metadatadetail thumbnailresolutionx;//0x502d
            public Metadatadetail thumbnailresolutiony;//0x502e;
            public Metadatadetail thumbnailplanarconfig;//0x502f
            public Metadatadetail thunbnailresolutionunit;//0x5030
            public Metadatadetail thumbnailtransferfunction;//0x5031
            public Metadatadetail thumbnailsoftwareused;//0x5032
            public Metadatadetail thumbnaildatetime;//0x5033
            public Metadatadetail thumbnailartist;//0x5034
            public Metadatadetail thumbnailwhitepoint;//0x5035
            public Metadatadetail thumbnailprimarychromaticities;//0x5036
            public Metadatadetail thumbnailycbcrcoefficients;//0x5037
            public Metadatadetail thumbnailycbcrsubsampling;//0x5038
            public Metadatadetail thumbnailycbcrpositioning;//0x5039
            public Metadatadetail thumbnailrefblackwhite;//0x503a
            public Metadatadetail thumbnailcopyright;//0x503b
            public Metadatadetail luminancetable;//0x5090
            public Metadatadetail chrominancetable;//0x5091
            public Metadatadetail framedelay;//0x5100
            public Metadatadetail loopcount;//0x5101
            public Metadatadetail pixelunit;//0x5110
            public Metadatadetail pixelperunitx;//0x5111
            public Metadatadetail pixelperunity;//0x5112
            public Metadatadetail palettehistogram;//0x5113
            public Metadatadetail dtdigitized;//0x9004
            public Metadatadetail makernote;//0x927c
            public Metadatadetail usercomment;//0x9286
            public Metadatadetail dtsubsec;//0x9290
            public Metadatadetail dtorigss;//0x9291
            public Metadatadetail dtdigss;//0x9292
            public Metadatadetail pixxdim;//0xa002
            public Metadatadetail pixydim;//0xa003
            public Metadatadetail relatedwav;//0xa004
            public Metadatadetail interopa005;//0xa005
            public Metadatadetail flashenergya20b;//0xa20b
            public Metadatadetail spatialfra20c;//0xa20c
            public Metadatadetail subjectloc;//0xa214
            public Metadatadetail fliesource;//0xa300
            public Metadatadetail gpsver;//0x0
            public Metadatadetail gpslatituderef;//0x1
            public Metadatadetail gpslatitude;//0x2
            public Metadatadetail gpslongituderref;//0x3
            public Metadatadetail gpslongitude;//0x4
            public Metadatadetail gpsaltituderref;//0x5
            public Metadatadetail gpsaltitude;//0x6
            public Metadatadetail gpsgpstime;//0x7
            public Metadatadetail gpsgpssatellites;//0x8
            public Metadatadetail gpsgpsstatus;//0x9
            public Metadatadetail gpsgpsmeasuremode;//0xa
            public Metadatadetail gpsgpsdop;//0xb
            public Metadatadetail gpsspeedref;//0xc
            public Metadatadetail gpsspeed;//0xd
            public Metadatadetail gpstrackref;//0xe
            public Metadatadetail gpstrack;//0xf
            public Metadatadetail gpsimgdirref;//0x10
            public Metadatadetail gpsimgdir;//0x11
            public Metadatadetail gpsmapdatum;//0x12
            public Metadatadetail gpsdestlatref;//0x13
            public Metadatadetail gpsdestlat;//0x14
            public Metadatadetail gpsdestlongref;//0x15
            public Metadatadetail gpsdestlong;//0x16
            public Metadatadetail gpsdestbearref;//0x17
            public Metadatadetail gpsdestbear;//0x18
            public Metadatadetail gpsdestdistref;//0x19
            public Metadatadetail gpsdestdist;//0x1a
        }
        public string lookupexifvalue(string description, string value)
        {
            string descriptionvalue = null;
            switch (description)
            {
                case "MeteringMode":
                    switch(value){
                        case "0":
                            descriptionvalue = "未知";
                            break;
                        case "1":
                            descriptionvalue = "平均测光";
                            break;
                        case "2":
                            descriptionvalue = "中央重点测光";
                            break;
                        case "3":
                            descriptionvalue = "点测光";
                            break;
                        case "4":
                            descriptionvalue = "多点测光";
                            break;
                        case "5":
                            descriptionvalue = "多区域测光";
                            break;
                        case "6":
                            descriptionvalue = "部分测光";
                            break;
                        case "255":
                            descriptionvalue = "其它";
                            break;
                    }
                    break;
                case "ResolutionUnit":
                    switch (value)
                    {
                        case "1":
                            descriptionvalue = "没有单位";
                            break;
                        case "2":
                            descriptionvalue = "英寸";
                            break;
                        case "3":
                            descriptionvalue = "厘米";
                            break;
                        default:
                            descriptionvalue = "其它单位";
                            break;
                    }
                    break;
                case "YCbCrPositioning":
                    switch (value)
                    {
                        case "1":
                            descriptionvalue = "像素阵列中心";
                            break;
                        case "2":
                            descriptionvalue = "基准点";
                            break;
                        default:
                            descriptionvalue = "其它子采样";
                            break;
                    }
                    break;
                case "Flash":
                    switch (value)
                    {
                        case "0":
                            descriptionvalue = "未使用";
                            break;
                        case "1":
                            descriptionvalue = "闪光灯闪光";
                            break;
                        case "5":
                            descriptionvalue = "闪光但没有检测反射光";
                            break;
                        case "7":
                            descriptionvalue = "闪光且检测了反射光";
                            break;
                        default:
                            descriptionvalue = "其它闪光方式";
                            break;
                    }
                    break;
                
                case "ExposureProg":
                    switch (value)
                    {
                        case "0":
                            descriptionvalue = "没有定义";
                            break;
                        case "1":
                            descriptionvalue = "手动控制";
                            break;
                        case "2":
                            descriptionvalue = "程序控制";
                            break;
                        case "3":
                            descriptionvalue = "光圈优先";
                            break;
                        case "4":
                            descriptionvalue = "快门优先";
                            break;
                        case "5":
                            descriptionvalue = "夜景模式";
                            break;
                        case "6":
                            descriptionvalue = "运动模式";
                            break;
                        case "7":
                            descriptionvalue = "肖像模式";
                            break;
                        case "8":
                            descriptionvalue = "风景模式";
                            break;
                        case "9":
                            descriptionvalue = "保留的";
                            break;
                    }
                    break;
                case "CompConfig":
                    switch (value)
                    {
                        case "513":
                            descriptionvalue = "YCbCr";
                            break;
                        default:
                            descriptionvalue = "RGB";
                            break;
                    }
                    break;
                case "Aperture":
                    descriptionvalue = value;
                    break;
                case "LightSource":
                    switch (value)
                    {
                        case "0":
                            descriptionvalue = "未知";
                            break;
                        case "1":
                            descriptionvalue = "日光";
                            break;
                        case "2":
                            descriptionvalue = "荧光灯";
                            break;
                        case "3":
                            descriptionvalue = "白炽灯";
                            break;
                        case "10":
                            descriptionvalue = "闪光灯";
                            break;
                        case "17":
                            descriptionvalue = "标准灯A";
                            break;
                        case "18":
                            descriptionvalue = "标准灯B";
                            break;
                        case "19":
                            descriptionvalue = "标准灯C";
                            break;
                        case "20":
                            descriptionvalue = "标准灯D55";
                            
                            break;
                        case "21":
                            descriptionvalue = "标准灯D65";
                            break;
                        case "22":
                            descriptionvalue = "标准灯D75";
                            break;
                        case "255":
                            descriptionvalue = "其它";
                            break;
                    }
                    break;

            }
            return descriptionvalue;
        }
        public metadata getexifmetadata(string photoname)
        {
            System.Drawing.Image myimage = System.Drawing.Image.FromFile(photoname);
            int[] mypropertyidlist = myimage.PropertyIdList;
            PropertyItem[] mypropertyitemlist=new PropertyItem[mypropertyidlist.Length];

            metadata mymetadata = new metadata();
            mymetadata.equipmentmake.hex = "10f";
            mymetadata.cameramodel.hex = "110";
            mymetadata.datepicturetaken.hex = "9003";
            mymetadata.exposuretime.hex = "829a";
            mymetadata.fstop.hex = "829d";
            mymetadata.shutterspeed.hex = "9201";
            mymetadata.meteringmode.hex = "9207";
            mymetadata.flash.hex = "9209";
            mymetadata.fnumber.hex = "829d";
            mymetadata.exposureprog.hex = "8822";
            mymetadata.spectralsense.hex = "8824";
            mymetadata.isospeed.hex = "8827";
            mymetadata.oecf.hex = "8828";
            mymetadata.ver.hex = "9000";
            mymetadata.compconfig.hex = "9101";
            mymetadata.compbpp.hex = "9102";
            mymetadata.aperture.hex = "9202";
            mymetadata.brightness.hex = "9203";
            mymetadata.exposurebias.hex = "9204";
            mymetadata.maxaperture.hex = "9205";
            mymetadata.subjectdist.hex = "9206";
            mymetadata.lightsource.hex = "9208";
            mymetadata.focallength.hex = "920a";
            mymetadata.fpxver.hex = "a000";
            mymetadata.colorspace.hex = "a001";
            mymetadata.focalxres.hex = "a20e";
            mymetadata.focalyres.hex = "a20f";
            mymetadata.focalresunit.hex = "a210";
            mymetadata.exposureinde.hex = "a215";
            mymetadata.sensingmethod.hex = "a217";
            mymetadata.scenetype.hex = "a301";
            mymetadata.cfapattern.hex = "a302";

            mymetadata.exififd.hex = "8769";
            mymetadata.gpsifd.hex = "8825";
            mymetadata.newsubfiletype.hex = "fe";
            mymetadata.subfiletype.hex = "ff";
            mymetadata.imagewidth100.hex = "100";
            mymetadata.imageheight101.hex = "101";
            mymetadata.bitspersample.hex = "102";
            mymetadata.compressionn.hex = "103";
            mymetadata.photometricinterp.hex = "106";
            mymetadata.threshholding.hex = "107";
            mymetadata.cellwidth.hex = "108";
            mymetadata.cellheight.hex = "109";
            mymetadata.fillorder.hex = "10a";
            mymetadata.documentname.hex = "10d";
            mymetadata.imagedescription.hex = "10e";
            mymetadata.stripoffsets.hex = "111";
            mymetadata.orientation.hex = "112";
            mymetadata.samplesperpixel.hex = "115";
            mymetadata.rowsperstrip.hex = "116";
            mymetadata.stripbytescount.hex = "117";
            mymetadata.minsamplevalue.hex = "118";
            mymetadata.maxsamplevalue.hex = "119";
            mymetadata.xresolution11a.hex = "11a";
            mymetadata.yresolution11b.hex = "11b";
            mymetadata.planarconfig.hex = "11c";
            mymetadata.pagename.hex = "11d";
            mymetadata.xposition.hex = "11e";
            mymetadata.yposition.hex = "11f";
            mymetadata.freeoffset.hex = "120";
            mymetadata.freebytecounts.hex = "121";
            mymetadata.grayresponseunit.hex = "122";
            mymetadata.grayresponsecurve.hex = "123";
            mymetadata.t4option.hex = "124";
            mymetadata.t6option.hex = "125";
            mymetadata.resolutionunit.hex = "128";
            mymetadata.pagenumber.hex = "129";
            mymetadata.transferfunctition.hex = "12d";
            mymetadata.softwareused.hex = "131";
            mymetadata.datetime.hex = "132";
            mymetadata.artist.hex = "13b";
            mymetadata.hostcomputer.hex = "13c";
            mymetadata.predictor.hex = "13d";
            mymetadata.whitepoint.hex = "13e";
            mymetadata.primarychromaticities.hex = "13f";
            mymetadata.colormap.hex = "140";
            mymetadata.halftonehints.hex = "141";
            mymetadata.tilewidth.hex = "142";
            mymetadata.tilelength.hex = "143";
            mymetadata.tileoffset.hex = "144";
            mymetadata.tilebytecounts.hex = "145";
            mymetadata.inkset.hex = "14c";
            mymetadata.inknames.hex = "14d";
            mymetadata.numberofinks.hex = "14e";
            mymetadata.dotrange.hex = "150";
            mymetadata.targetprinter.hex = "151";
            mymetadata.extrasamples.hex = "152";
            mymetadata.sampleformat.hex = "153";
            mymetadata.sminsamplevalue.hex = "154";
            mymetadata.smaxsamplevalue.hex = "155";
            mymetadata.transferrange.hex = "156";
            mymetadata.jpegproc.hex = "200";
            mymetadata.jpeginterformat.hex = "201";
            mymetadata.jpeginterlength.hex = "202";
            mymetadata.jpegrestartinterval.hex = "203";
            mymetadata.jpeglosslesspredictors.hex = "205";
            mymetadata.jpegpointtransforms.hex = "206";
            mymetadata.jpegqtables.hex = "207";
            mymetadata.jpegdctables.hex = "208";
            mymetadata.jpegactables.hex = "209";
            mymetadata.ycbcrcoefficients.hex = "211";
            mymetadata.ycbcrsubsampling.hex = "212";
            mymetadata.ycbcrpositioning.hex = "213";
            mymetadata.refblackwhite.hex = "214";
            mymetadata.iccprofile.hex = "8773";
            mymetadata.gamma.hex = "301";
            mymetadata.iccprofiledescriptor.hex = "302";
            mymetadata.srgbrenderingintent.hex = "303";
            mymetadata.imagetitle.hex = "320";
            mymetadata.copyright.hex = "8298";
            mymetadata.resolutionxunit.hex = "5001";
            mymetadata.resolutionxlengthunit.hex = "5003";
            mymetadata.resolutionyunit.hex = "5002";
            mymetadata.resolutionylengthunit.hex = "5004";
            mymetadata.printflags.hex = "5005";
            mymetadata.printflagsversion.hex = "5006";
            mymetadata.printflagsbleedwidth.hex = "5008";
            mymetadata.printflagscrop.hex = "5007";
            mymetadata.printflagsbleedwidthscale.hex = "5009";
            mymetadata.halftonelpi.hex = "500a";
            mymetadata.halftonelpiunit.hex = "500b";
            mymetadata.halftonedegree.hex = "500c";
            mymetadata.halftoneshape.hex = "500d";
            mymetadata.halftonemisc.hex = "500e";
            mymetadata.halftonescreen.hex = "500f";
            mymetadata.jpegquality.hex = "5010";
            mymetadata.gridsize.hex = "5011";
            mymetadata.thumbnailformat.hex = "5012";
            mymetadata.thumbnailwidth.hex = "5013";
            mymetadata.thumbnailheight.hex = "5014";
            mymetadata.thumbnailcolordepth.hex = "5015";
            mymetadata.thumbnailplanes.hex = "5016";
            mymetadata.thumbnailrawbytes.hex = "5017";
            mymetadata.thumbnailsize.hex = "5018";
            mymetadata.thumbnailcompressedsize.hex = "5019";
            mymetadata.colortransferfuntion.hex = "501a";
            mymetadata.thumbnaildata.hex = "501b";
            mymetadata.thumbnailimagewidth.hex = "5020";
            mymetadata.thumbnailimageheight.hex = "5021";
            mymetadata.thumbnailbitspersample.hex = "5022";
            mymetadata.thumbnailcompression.hex = "5023";
            mymetadata.thumbnailphotometricinterp.hex = "5024";
            mymetadata.thumbnailimagedescription.hex = "5025";
            mymetadata.thumbnailequipmake.hex = "5026";
            mymetadata.thumbnailequipmodel.hex = "5027";
            mymetadata.thumbnailstripoffsets.hex = "5028";
            mymetadata.thumbnailorientation.hex = "5029";
            mymetadata.thumbnailsamplesperpixel.hex = "502a";
            mymetadata.thumbnailrowsperstrip.hex = "502b";
            mymetadata.thumbnailstripbytescount.hex = "502c";
            mymetadata.thumbnailresolutionx.hex = "502d";
            mymetadata.thumbnailresolutiony.hex = "502e";
            mymetadata.thumbnailplanarconfig.hex = "502f";
            mymetadata.thunbnailresolutionunit.hex = "5030";
            mymetadata.thumbnailtransferfunction.hex = "5031";
            mymetadata.thumbnailsoftwareused.hex = "5032";
            mymetadata.thumbnaildatetime.hex = "5033";
            mymetadata.thumbnailartist.hex = "5034";
            mymetadata.thumbnailwhitepoint.hex = "5035";
            mymetadata.thumbnailprimarychromaticities.hex = "5036";
            mymetadata.thumbnailycbcrcoefficients.hex = "5037";
            mymetadata.thumbnailycbcrsubsampling.hex = "5038";
            mymetadata.thumbnailycbcrpositioning.hex = "5039";
            mymetadata.thumbnailrefblackwhite.hex = "503a";
            mymetadata.thumbnailcopyright.hex = "503b";
            mymetadata.luminancetable.hex = "5090";
            mymetadata.chrominancetable.hex = "5091";
            mymetadata.framedelay.hex = "5100";
            mymetadata.loopcount.hex = "5101";
            mymetadata.pixelunit.hex = "5110";
            mymetadata.pixelperunitx.hex = "5111";
            mymetadata.pixelperunity.hex = "5112";
            mymetadata.planarconfig.hex = "5113";
            mymetadata.dtdigitized.hex = "9004";
            mymetadata.makernote.hex = "927c";
            mymetadata.usercomment.hex = "9286";
            mymetadata.dtsubsec.hex = "9290";
            mymetadata.dtorigss.hex = "9291";
            mymetadata.dtdigss.hex = "9292";
            mymetadata.pixxdim.hex = "a002";
            mymetadata.pixydim.hex = "a003";
            mymetadata.relatedwav.hex = "a004";
            mymetadata.interopa005.hex = "a005";
            mymetadata.flashenergya20b.hex = "a20b";
            mymetadata.spatialfra20c.hex = "a20c";
            mymetadata.subjectloc.hex = "a214";
            mymetadata.fliesource.hex = "a300";
            mymetadata.gpsver.hex = "0";
            mymetadata.gpslatituderef.hex = "1";
            mymetadata.gpslatitude.hex = "2";
            mymetadata.gpslongituderref.hex = "3";
            mymetadata.gpslongitude.hex = "4";
            mymetadata.gpsaltituderref.hex = "5";
            mymetadata.gpsaltitude.hex = "6";
            mymetadata.gpsgpstime.hex = "7";
            mymetadata.gpsgpssatellites.hex = "8";
            mymetadata.gpsgpsstatus.hex = "9";
            mymetadata.gpsgpsmeasuremode.hex = "a";
            mymetadata.gpsgpsdop.hex = "b";
            mymetadata.gpsspeedref.hex = "c";
            mymetadata.gpsspeed.hex = "d";
            mymetadata.gpstrackref.hex = "e";
            mymetadata.gpstrack.hex = "f";
            mymetadata.gpsimgdirref.hex = "10";
            mymetadata.gpsimgdir.hex = "11";
            mymetadata.gpsmapdatum.hex = "12";
            mymetadata.gpsdestlatref.hex = "13";
            mymetadata.gpsdestlat.hex = "14";
            mymetadata.gpsdestlongref.hex = "15";
            mymetadata.gpsdestlong.hex = "16";
            mymetadata.gpsdestbearref.hex = "17";
            mymetadata.gpsdestbear.hex = "18";
            mymetadata.gpsdestdistref.hex = "19";
            mymetadata.gpsdestdist.hex = "20";

            System.Text.ASCIIEncoding value = new System.Text.ASCIIEncoding();
            int index = 0;
            int mypropertyidlistcount = mypropertyidlist.Length;
            if (mypropertyidlistcount != 0)
            {
                foreach (int mypropertyid in mypropertyidlist)
                {
                    string hexval = "";
                    mypropertyitemlist[index] = myimage.GetPropertyItem(mypropertyid);
                    string mypropertyidstring = myimage.GetPropertyItem(mypropertyid).Id.ToString("x");
                    switch (mypropertyidstring)
                    {
                        case "0":
                            hexval = "0";
                            break;
                        case "1":
                            mymetadata.gpslatituderef.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            string ns = value.GetString(mypropertyitemlist[index].Value);
                            if (ns == "N\0")
                                mymetadata.gpslatituderef.displayvalue = "北纬";
                            else
                                mymetadata.gpslatituderef.displayvalue = "南纬";
                            break;
                        case "2":
                            mymetadata.gpslatitude.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            uint u1 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 0);
                            uint u2 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 4);
                            uint u3 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 8);
                            uint u4 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 12);
                            uint u5 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 16);
                            uint u6 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 20);
                            float myf = u1 / (float)u2+(u3/(float)u4)/60f+(u5/(float)u6)/3600f;
                            mymetadata.gpslatitude.displayvalue = ""+myf;//value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "3":
                            mymetadata.gpslongituderref.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            string we = value.GetString(mypropertyitemlist[index].Value);
                            if (we == "E\0")
                                mymetadata.gpslongituderref.displayvalue = "东经";
                            else
                                mymetadata.gpslongituderref.displayvalue = "西经";
                            break;
                        case "4":
                            mymetadata.gpslongitude.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            uint e1 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 0);
                            uint e2 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 4);
                            uint e3 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 8);
                            uint e4 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 12);
                            uint e5 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 16);
                            uint e6 = BitConverter.ToUInt32(myimage.GetPropertyItem(mypropertyid).Value, 20);
                            float mf = e1 / (float)e2 + (e3 / (float)e4) / 60f + (e5 / (float)e6) / 3600f;
                            mymetadata.gpslongitude.displayvalue = "" + mf;
                            break;
                        case "5":
                            mymetadata.gpsaltituderref.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.gpsaltituderref.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            if (mymetadata.gpsaltituderref.displayvalue == "\0")
                                mymetadata.gpsaltituderref.displayvalue = "水平面以上";
                            else
                                mymetadata.gpsaltituderref.displayvalue = "水平面以下";
                            break;
                        case "6":
                            mymetadata.gpsaltitude.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.gpsaltitude.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "10f"://mymetadata.equipmentmake.hex
                            mymetadata.equipmentmake.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.equipmentmake.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "110":
                            mymetadata.cameramodel.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.cameramodel.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "11a":
                            break;
                        case "11b":
                            break;
                        case "128"://ResolutionUnit
                            mymetadata.resolutionunit.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.resolutionunit.displayvalue = lookupexifvalue("ResolutionUnit", BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value, 0).ToString());
                            break;
                        case "131":
                            mymetadata.softwareused.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.softwareused.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "132":
                            mymetadata.datetime.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.datetime.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "213":
                            mymetadata.ycbcrsubsampling.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.ycbcrsubsampling.displayvalue = lookupexifvalue("YCbCrPositioning", BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value, 0).ToString());
                            break;
                        case "9003":
                            mymetadata.datepicturetaken.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.datepicturetaken.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9290":
                            mymetadata.dtsubsec.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.dtsubsec.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9291":
                            mymetadata.dtorigss.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.dtorigss.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9292":
                            mymetadata.dtdigss.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.dtdigss.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9004":
                            mymetadata.dtdigitized.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.dtdigitized.displayvalue = value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9207":
                            mymetadata.meteringmode.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.meteringmode.displayvalue=lookupexifvalue("MeteringMode",BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString());
                            break;
                        case "9209":
                            mymetadata.flash.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.flash.displayvalue=lookupexifvalue("Flash",BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString());
                            break;
                        case "829a":
                            /*mymetadata.exposuretime.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            string stringvalue="";
                            for(int offset=0;offset<myimage.GetPropertyItem(mypropertyid).Len;offset=offset+4)
                            {
                                stringvalue+=BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value,offset).ToString();
                            }
                            mymetadata.exposuretime.displayvalue=stringvalue.Substring(0,stringvalue.Length-1);*/
                            hexval="";
                            mymetadata.exposuretime.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            hexval=Convert.ToInt32(hexval,16).ToString();
                            hexval=hexval+"00";
                            mymetadata.exposuretime.displayvalue = hexval.Substring(0, 1) + "." + hexval.Substring(1, 2);
                            break;
                        case "829d":
                            mymetadata.fstop.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            int int1,int2;
                            int1=BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value,0);
                            int2=BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value,4);
                            mymetadata.fstop.displayvalue="F/"+(int1/int2);
                            mymetadata.fnumber.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.fnumber.displayvalue=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "9201":
                            mymetadata.shutterspeed.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            string stringvalue1=BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            mymetadata.shutterspeed.displayvalue="1/"+stringvalue1;
                            break;
                        case "8822":
                            mymetadata.exposureprog.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.exposureprog.displayvalue=lookupexifvalue("ExposureProg",BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString());
                            break;
                        case "8824":
                            mymetadata.spectralsense.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.spectralsense.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "8827":
                            hexval="";
                            mymetadata.isospeed.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            mymetadata.isospeed.displayvalue=Convert.ToInt32(hexval,16).ToString();
                            break;
                        case "8828":
                            mymetadata.oecf.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.oecf.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9000":
                            mymetadata.ver.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.ver.displayvalue=value.GetString(mypropertyitemlist[index].Value).Substring(1,1)+"."+value.GetString(mypropertyitemlist[index].Value).Substring(2,2);
                            break;
                        case "9001":
                            mymetadata.compconfig.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.compconfig.displayvalue=lookupexifvalue("CompConfig",BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString());
                            break;
                        case "9101":
                            mymetadata.compconfig.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.compconfig.displayvalue = lookupexifvalue("CompConfig", BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value, 0).ToString());
                            break;
                        case "9102":
                            mymetadata.compbpp.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.compbpp.displayvalue=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "9202":
                            hexval="";
                            mymetadata.aperture.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            hexval=Convert.ToInt32(hexval,16).ToString();
                            hexval=hexval+"00";
                            mymetadata.aperture.displayvalue=hexval.Substring(0,1)+"."+hexval.Substring(1,2);
                            break;
                        case "9203":
                            hexval="";
                            mymetadata.brightness.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            hexval=Convert.ToInt32(hexval,16).ToString();
                            hexval=hexval+"00";
                            mymetadata.brightness.displayvalue=hexval.Substring(0,1)+"."+hexval.Substring(1,2);
                            break;
                        case "9204":
                            mymetadata.exposurebias.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.exposurebias.displayvalue=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "9205":
                            hexval="";
                            mymetadata.maxaperture.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            hexval=Convert.ToInt32(hexval,16).ToString();
                            hexval=hexval+"00";
                            mymetadata.maxaperture.displayvalue=hexval.Substring(0,1)+"."+hexval.Substring(1,2);
                            break;
                        case "9206":
                            mymetadata.subjectdist.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.subjectdist.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "9208":
                            mymetadata.lightsource.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.lightsource.displayvalue=lookupexifvalue("LightSource",BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString());
                            break;
                        case "920a":
                            hexval="";
                            mymetadata.focallength.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            hexval=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value).Substring(0,2);
                            hexval=Convert.ToInt32(hexval,16).ToString();
                            hexval=hexval+"00";
                            mymetadata.focallength.displayvalue=hexval.Substring(0,1)+"."+hexval.Substring(1,2);
                            break;
                        case "a000":
                            mymetadata.fpxver.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.fpxver.displayvalue=value.GetString(mypropertyitemlist[index].Value).Substring(1,1)+"."+value.GetString(mypropertyitemlist[index].Value).Substring(2,2);
                            break;
                        case "a001":
                            mymetadata.colorspace.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            if(BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString()=="1")
                                mymetadata.colorspace.displayvalue="RGB";
                            if(BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString()=="65535")
                                mymetadata.colorspace.displayvalue="Uncalibrated";
                            break;
                        case "a002":
                            mymetadata.pixxdim.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.pixxdim.displayvalue = BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value, 0).ToString();
                            break;
                        case "a003":
                            mymetadata.pixydim.rawvalueasstring = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.pixydim.displayvalue=BitConverter.ToInt32(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "a20e":
                            mymetadata.focalxres.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.focalxres.displayvalue=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "a20f":
                            mymetadata.focalyres.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.focalyres.displayvalue=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            break;
                        case "a210":
                            string aa;
                            mymetadata.focalresunit.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            aa=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            if(aa=="1") mymetadata.focalresunit.displayvalue="没有单位";
                            if(aa=="2") mymetadata.focalresunit.displayvalue="英尺";
                            if(aa=="3") mymetadata.focalresunit.displayvalue="厘米";
                            break;
                        case "a215":
                            mymetadata.exposureinde.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.exposureinde.displayvalue=value.GetString(mypropertyitemlist[index].Value);
                            break;
                        case "a217":
                            string a;
                            a=BitConverter.ToInt16(myimage.GetPropertyItem(mypropertyid).Value,0).ToString();
                            mymetadata.sensingmethod.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            if (a == "2")
                                mymetadata.sensingmethod.displayvalue = "一个芯片颜色区域传感器";
                            else
                                mymetadata.sensingmethod.displayvalue = "其它图像传感器类型";
                            break;
                        case "a301":
                            mymetadata.scenetype.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            //mymetadata.scenetype.displayvalue=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            string b = BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            if(b=="1")
                                mymetadata.scenetype.displayvalue="照相机直接拍摄";
                            else
                                mymetadata.scenetype.displayvalue="其它方式拍摄出来";
                            break;
                        case "a302":
                            mymetadata.cfapattern.rawvalueasstring=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            mymetadata.cfapattern.displayvalue=BitConverter.ToString(myimage.GetPropertyItem(mypropertyid).Value);
                            break;
                    }
                    index++;
                }
            }
            mymetadata.xresolution.displayvalue=myimage.HorizontalResolution.ToString();
            mymetadata.yresolution.displayvalue=myimage.VerticalResolution.ToString();
            mymetadata.imageheight.displayvalue=myimage.Height.ToString();
            mymetadata.imagewidth.displayvalue=myimage.Width.ToString();
            myimage.Dispose();
            return mymetadata;
        }
        private void getpictureinfo()
        {
            string filepath = textBox1.Text;

            metadata md = getexifmetadata(filepath);
            string dispstr = "";
            string temp = "";
            string exif = md.ver.displayvalue;
            dispstr = "EXIF版本:\t" + exif + "\r\n";
            string camera = md.cameramodel.displayvalue;
            camera = camera.Replace("\0", string.Empty);
            if (camera == null)
                camera = "null";
            dispstr = dispstr + "相机型号:\t" + camera + "\r\n";
            string maker = md.equipmentmake.displayvalue;
            if (maker == null)
                maker = "null";
            maker = maker.Replace("\0", string.Empty);
            dispstr = dispstr + "制造商:\t\t" + maker + "\r\n";
            string aperture = md.aperture.displayvalue;
            if (aperture == null)
                aperture = "null";
            dispstr = dispstr + "光圈值:\t\t" + aperture + "\r\n";
            string shutter = md.shutterspeed.displayvalue;
            if (shutter == null)
                shutter = "null";

            dispstr = dispstr + "快门值:\t\t" + shutter + "\r\n";
            string resolutionxy = "照片分辨率:\t" + md.imagewidth.displayvalue + "X" + md.imageheight.displayvalue + "\r\n";
            dispstr = dispstr + resolutionxy;

            temp = "";
            if (md.ver.displayvalue == null)
                temp = "null";
            else
                temp = md.ver.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "exif版本号:\t" + temp + "\r\n";
            string weidu = "";
            string jingdu = "";
            temp = "";
            if (md.gpslatituderef.displayvalue == null)
                temp = "null";
            else
                temp = md.gpslatituderef.displayvalue;
            dispstr = dispstr + "南北纬:\t\t" + temp + "\r\n";

            temp = "";
            if (md.gpslatitude.displayvalue == null)
                temp = "null";
            else
                temp = md.gpslatitude.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "纬度:\t\t" + temp + "\r\n";
            weidu = temp;
            temp = "";
            if (md.gpslongituderref.displayvalue == null)
                temp = "null";
            else
                temp = md.gpslongituderref.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "东西经:\t\t" + temp + "\r\n";

            temp = "";
            if (md.gpslongitude.displayvalue == null)
                temp = "null";
            else
                temp = md.gpslongitude.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "经度:\t\t" + temp + "\r\n";
            jingdu = temp;
            temp = "";
            if (md.gpsaltituderref.displayvalue == null)
                temp = "null";
            else
                temp = md.gpsaltituderref.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "水平高度:\t" + temp + "\r\n";

            temp = "";
            if (md.resolutionunit.displayvalue == null)
                temp = "null";
            else
                temp = md.resolutionunit.displayvalue;
            string resolutionunit = "分辨率单位:\t" + temp + "\r\n";
            dispstr = dispstr + resolutionunit;

            temp = "";
            if (md.exposuretime.displayvalue == null)
                temp = "null";
            else
                temp = md.exposuretime.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "曝光时间秒:\t" + temp + "\r\n";

            temp = "";
            if (md.exposureprog.displayvalue == null)
                temp = "null";
            else
                temp = md.exposureprog.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "曝光模式:\t" + temp + "\r\n";

            temp = "";
            if (md.isospeed.displayvalue == null)
                temp = "null";
            else
                temp = md.isospeed.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "CCD 的感光度:\t" + temp + "\r\n";

            temp = "";
            if (md.fnumber.displayvalue == null)
                temp = null;
            else
                temp = md.fnumber.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "拍照光圈:\t" + temp + "\r\n";

            temp = "";
            if (md.softwareused.displayvalue == null)
                temp = "null";
            else
                temp = md.softwareused.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "固件版本:\t" + temp + "\r\n";

            temp = "";
            if (md.datetime.displayvalue == null)
                temp = "null";
            else
                temp = md.datetime.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "照片修改日期:\t" + temp + "\r\n";

            temp = "";
            if (md.dtsubsec.displayvalue == null)
                temp = "null";
            else
                temp = md.dtsubsec.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "修改毫秒数:\t" + temp + "\r\n";

            temp = "";
            if (md.dtdigitized.displayvalue == null)
                temp = "null";
            else
                temp = md.dtdigitized.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "照片数字化时间:\t" + temp + "\r\n";

            temp = "";
            if (md.dtdigss.displayvalue == null)
                temp = "null";
            else
                temp = md.dtdigss.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "照片数字化毫秒:\t" + temp + "\r\n";

            temp = "";
            if (md.datepicturetaken.displayvalue == null)
                temp = "null";
            else
                temp = md.datepicturetaken.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "照片拍摄时间:\t" + temp + "\r\n";

            temp = "";
            if (md.dtorigss.displayvalue == null)
                temp = "null";
            else
                temp = md.dtorigss.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "照片拍摄毫秒:\t" + temp + "\r\n";
            temp = "";
            if (md.compconfig.displayvalue == null)
                temp = "null";
            else
                temp = md.compconfig.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "像素格式:\t" + temp + "\r\n";

            temp = "";
            if (md.fpxver.displayvalue == null)
                temp = "null";
            else
                temp = md.fpxver.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "FlashPix版本:\t" + temp + "\r\n";

            temp = "";
            if (md.brightness.displayvalue == null)
                temp = "null";
            else
                temp = md.brightness.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "物体亮度:\t" + temp + "\r\n";

            temp = "";
            if (md.meteringmode.displayvalue == null)
                temp = "null";
            else
                temp = md.meteringmode.displayvalue;
            dispstr = dispstr + "测光方式:\t" + temp + "\r\n";

            temp = "";
            if (md.focallength.displayvalue == null)
                temp = "null";
            else
                temp = md.focallength.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "焦距:\t\t" + temp + "\r\n";

            temp = "";
            if (md.flash.displayvalue == null)
                temp = "null";
            else
                temp = md.flash.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "闪光方式:\t" + temp + "\r\n";

            temp = "";
            if (md.colorspace.displayvalue == null)
                temp = "null";
            else
                temp = md.colorspace.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "颜色空间格式:\t" + temp + "\r\n";

            temp = "";
            if (md.pixxdim.displayvalue == null)
                temp = "null";
            else
                temp = md.pixxdim.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "主图像尺寸:\t" + temp+"X";
            temp = "";
            if (md.pixydim.displayvalue == null)
                temp = "null";
            else
                temp = md.pixydim.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + temp + "\r\n";

            temp = "";
            if (md.sensingmethod.displayvalue == null)
                temp = "null";
            else
                temp=md.sensingmethod.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "图像传感器类型:\t" + temp + "\r\n";

            temp = "";
            if (md.scenetype.displayvalue == null)
                temp = "null";
            else
                temp = md.scenetype.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "拍摄场景:\t" + temp + "\r\n";

            temp = "";
            if (md.ycbcrsubsampling.displayvalue == null)
                temp = "null";
            else
                temp = md.ycbcrsubsampling.displayvalue;
            temp = temp.Replace("\0", string.Empty);
            dispstr = dispstr + "YCbCr子采样:\t" + temp + "\r\n";

            string sensitive = md.exposureinde.displayvalue;
            if (sensitive == null)
                sensitive = "null";
            dispstr = dispstr + "ccd感光度:\t" + sensitive + "\r\n";
            richTextBox1.Text = dispstr;
            int isjingweidu = 0;
            if (jingdu == "null" || weidu == "null")
                isjingweidu = 0;
            else
                isjingweidu = 1;
            
            getaddressbylatandlng(isjingweidu,jingdu, weidu);
            //调用百度地图
            /*
            webBrowser1.ScriptErrorsSuppressed = true;
            string path = "C:\\Users\\feng\\Documents\\Visual Studio 2012\\Projects\\csharpgetpictureinfo\\csharpgetpictureinfo\\HTMLPage1.html";
            webBrowser1.Navigate(path);
            object[] args = {jingdu,weidu};
            try
            {
                webBrowser1.Document.InvokeScript("addmarkey", args);
            }
            catch (Exception ee)
            {
            }*/
            //把坐标导入百度地图
            portpositiontobaidumap(isjingweidu, jingdu, weidu);
            
            /*Uri uri = new Uri("https://map.baidu.com");
            webBrowser1.Url = uri;
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.ObjectForScripting = this;
            string slng=webBrowser1.Document.GetElementById("lng").*/
        }

        private void portpositiontobaidumap(int isjingweidu, string jingdu, string weidu)
        {
            if (isjingweidu == 0)
            {
                return;
            }
            isgetjingweidu = isjingweidu;
            gjingdu = jingdu;
            gweidu = weidu;
            textBox2.Text=gjingdu;
            textBox3.Text = gweidu;
            try
            {
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "HTMLPage1.html"));
                //MessageBox.Show(webBrowser1.Url.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
            
            //webBrowser1.Document.InvokeScript("setLocation", new object[] { float.Parse(jingdu), float.Parse(weidu) });
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                //webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "HTMLPage1.html"));
                //webBrowser1.Document.InvokeScript("setLocation", new object[] { float.Parse(gjingdu), float.Parse(gweidu) });
                webBrowser1.Document.InvokeScript("setLocation", new object[] { float.Parse(gjingdu), float.Parse(gweidu) });
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //isjingweidu 是否在照片里获取经纬度，如果获取不了，值为0，
        private void getaddressbylatandlng(int isjingweidu,string jingdu, string weidu)
        {
            if (isjingweidu == 0)
            {
                richTextBox2.Clear();
                richTextBox2.Text = "照片里没有位置信息";
                return;
            }
            string ak="aqsnzZGkpZAzXGs2xQFD1vNVV9zPIg7O";
            string url = @"http://api.map.baidu.com/reverse_geocoding/v3/?ak=" + ak + "&output=json&coordtype=bd0911&location=" + weidu + "," + jingdu;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.KeepAlive = false;
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myresponsestream = response.GetResponseStream();
            StreamReader myreader = new StreamReader(myresponsestream, Encoding.GetEncoding("utf-8"));
            string retstr = myreader.ReadToEnd();
            myreader.Close();
            myresponsestream.Close();
            response.Close();
            request.Abort();
            //		retstr	"{\"status\":0,\"result\":{\"location\":{\"lng\":113.32429999999997,\"lat\":23.081990010243538},\"formatted_address\":\"广东省广州市海珠区上冲南约24\",\"business\":\"广州大道南,南洲,赤岗\",\"addressComponent\":{\"country\":\"中国\",\"country_code\":0,\"country_code_iso\":\"CHN\",\"country_code_iso2\":\"CN\",\"province\":\"广东省\",\"city\":\"广州市\",\"city_level\":2,\"district\":\"海珠区\",\"town\":\"\",\"town_code\":\"\",\"adcode\":\"440105\",\"street\":\"上冲南约\",\"street_number\":\"24\",\"direction\":\"西\",\"distance\":\"99\"},\"pois\":[],\"roads\":[],\"poiRegions\":[],\"sematic_description\":\"\",\"cityCode\":257}}"	string
            //分析返回字符串
            string sub1 = "formatted_address\":\"";
            int leng1 = sub1.Length;
            string sub1end = "\",";
            int sub1pos = retstr.IndexOf(sub1);
            if (sub1pos < 0)
            {
                MessageBox.Show("百度定位失败");
                return;
            }
            sub1pos+=leng1;
            int sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string address1 = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            string disstr = "照片地址：" + address1 + "\r\n";
            //商圈
            sub1 = "business\":\"";
            leng1 = sub1.Length;
            sub1end = "\",";
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string shangquan = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (shangquan.Length < 1)
            {
                disstr = disstr+"商圈：" + "\r\n";
            }
            else
            {
                disstr = disstr+"商圈：" + shangquan + "\r\n";
            }
            //国家
            sub1 = "country\":\"";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string guojia = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (guojia.Length < 1)
            {
                disstr = disstr + "国家：" + "\r\n";
            }
            else
            {
                disstr = disstr + "国家：" + guojia + "\r\n";
            }
            //省
            sub1 = "province\":\"";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string sheng = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (sheng.Length < 1)
            {
                disstr = disstr + "省：" + "\r\n";
            }
            else
            {
                disstr = disstr + "省：" + sheng + "\r\n";
            }
            //市
            sub1 = "city\":\"";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string shi = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (shi.Length < 1)
            {
                disstr = disstr + "市：" + "\r\n";
            }
            else
            {
                disstr = disstr + "市：" + shi + "\r\n";
            }
            //行政区号
            sub1 = "adcode\":\"";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string adcode = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (adcode.Length < 1)
            {
                disstr = disstr + "行政区号：" + "\r\n";
            }
            else
            {
                disstr = disstr + "行政区号：" + adcode + "\r\n";
            }
            //门牌方向（相对于当前经纬度坐标）
            sub1 = "direction\":\"";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string direction = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (direction.Length < 1)
            {
                disstr = disstr + "门牌方向：" + "\r\n";
            }
            else
            {
                disstr = disstr + "门牌方向：" + direction + "\r\n";
            }
            //门牌距离
            sub1 = "distance\":\"";
            sub1end = "\"},";
            leng1 = sub1.Length;
            sub1pos = retstr.IndexOf(sub1);
            sub1pos += leng1;
            sub1endpos = retstr.IndexOf(sub1end, sub1pos);
            string distance = retstr.Substring(sub1pos, sub1endpos - sub1pos);
            if (distance.Length < 1)
            {
                disstr = disstr + "门牌距离：" + "\r\n";
            }
            else
            {
                disstr = disstr + "门牌距离：" + distance + "\r\n";
            }
            richTextBox2.Clear();
            richTextBox2.Text = disstr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openfiledialog = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPEG|*.jpg;*.jpeg;*.jpe;*.jfif";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
                    try
                    {
                        if (filename != string.Empty)
                        {
                            pictureBox1.Image = Image.FromFile(filename);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    getpictureinfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int isjingweidu = 1;
            string jingdu = textBox2.Text;
            string weidu = textBox3.Text;
            portpositiontobaidumap(isjingweidu, jingdu, weidu);
        }

        
    }
}
