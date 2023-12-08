using System.Net.Http.Headers;

namespace Day8
{
    public class Program
    {
        internal static string pathSequence = "LRRRLRRRLRRLRLRRLRLRRLRRLRLLRRRLRLRLRRRLRRRLRLRLRLLRRLLRRLRRRLLRLRRRLRLRLRRRLLRLRRLRRRLRLRRRLLRLRRLRRRLRRLRRLRLRRLRRRLRLRRRLRRLLRRLRRLRLRRRLRRLRRRLRRRLRLRRLRLRRRLRLRRLRRLRRRLRRRLRRRLLRRLRRRLRLRLRLRRRLRLRLRRLRRRLRRRLRRLRRLLRLRRLLRLRRLRRLLRLLRRRLLRRLLRRLRRLRLRLRRRLLRRLRRRR";
        internal static string nodes = "DBQ = (RTP, NBX)\r\nNFX = (PXX, PLG)\r\nVBK = (BRV, DKG)\r\nBRS = (HLR, VBX)\r\nDDK = (SPR, TCR)\r\nFTS = (LJB, MDJ)\r\nBLH = (DFM, GGG)\r\nPCC = (GQR, RHD)\r\nQKN = (VVR, GBL)\r\nKHN = (FNB, LLT)\r\nHTD = (NPJ, BTL)\r\nFPL = (BRX, XQD)\r\nRCJ = (QKN, XPD)\r\nXRN = (RMQ, LQB)\r\nHGM = (VPV, SVR)\r\nRFG = (TLM, KPH)\r\nSSG = (QGC, KJV)\r\nLPA = (QQN, GNF)\r\nSVN = (VLM, BDX)\r\nVPF = (TTR, RNQ)\r\nVNK = (DSX, MCZ)\r\nKMS = (XNN, MTB)\r\nRLS = (NHX, CRT)\r\nVRS = (VBX, HLR)\r\nTVK = (MKG, NKB)\r\nCKH = (DFF, XPV)\r\nKBS = (LJC, PRS)\r\nJMT = (FPT, DLX)\r\nLRV = (QCD, RLF)\r\nTMM = (VPF, GKD)\r\nHKH = (PRS, LJC)\r\nGSM = (SVH, KRP)\r\nSLG = (PTL, SNJ)\r\nGVS = (DSN, CKH)\r\nQGC = (HKS, DFP)\r\nRFT = (VVQ, GMF)\r\nFDF = (JKV, JKV)\r\nMRL = (PKS, TKS)\r\nHBN = (BDX, VLM)\r\nCFB = (PPV, QVS)\r\nTFJ = (KGN, JND)\r\nHLB = (PFV, JXR)\r\nRFJ = (SKL, QCN)\r\nPQH = (KGN, JND)\r\nHGR = (FKL, XHR)\r\nCTB = (HNQ, HNQ)\r\nXMN = (CJV, LKQ)\r\nJVX = (FSS, CRC)\r\nSFH = (MXD, RHN)\r\nBRK = (QPL, DJB)\r\nHBX = (DSN, CKH)\r\nRFL = (VXB, FNF)\r\nGXP = (LHR, SMV)\r\nCHK = (NLQ, VCR)\r\nQPG = (HHL, KHB)\r\nVBC = (NFV, FST)\r\nQJF = (JXL, JJC)\r\nXKQ = (PCS, BSH)\r\nSKS = (SNN, QSN)\r\nGJJ = (VVG, XPR)\r\nDJP = (SJM, DNR)\r\nDQF = (MHG, BKZ)\r\nMSB = (BRX, XQD)\r\nPQR = (TLL, RVS)\r\nXGB = (RMT, HGF)\r\nHBD = (PFD, FDN)\r\nNSN = (RFJ, NJT)\r\nSNJ = (MVG, DBQ)\r\nNMV = (SKG, TDJ)\r\nPTN = (TNR, SSG)\r\nSBG = (CVH, LMJ)\r\nRDT = (SVQ, JTT)\r\nMRC = (BKF, QMJ)\r\nJKV = (CTB, CTB)\r\nCTX = (QHL, BDV)\r\nSQM = (DNR, SJM)\r\nMVG = (RTP, NBX)\r\nKKJ = (TQP, PST)\r\nQKX = (BRD, SFT)\r\nVFV = (NTL, VMQ)\r\nLXK = (SSL, MFR)\r\nHDH = (VPS, MJH)\r\nRTP = (CGJ, XJC)\r\nBXQ = (FLN, FLN)\r\nGKD = (TTR, RNQ)\r\nGPP = (SNN, QSN)\r\nGDQ = (JLS, TND)\r\nLTF = (GXP, TVB)\r\nGVB = (LSV, FRL)\r\nJCF = (HGR, GMX)\r\nVCR = (JTR, MCM)\r\nXJC = (DGP, XML)\r\nXKA = (SFC, CHQ)\r\nLJL = (VPX, PMS)\r\nCPH = (PCQ, QKX)\r\nVPV = (TFP, NJN)\r\nTDJ = (PRV, DBK)\r\nJGQ = (TPX, NMV)\r\nLJS = (GDQ, QPV)\r\nVHN = (CBJ, PFQ)\r\nJHT = (XHM, NRK)\r\nZZZ = (HJS, LRV)\r\nKJV = (HKS, DFP)\r\nHNT = (XXT, KJT)\r\nRHD = (KQH, TMD)\r\nJKG = (HXJ, MGF)\r\nSPL = (TTB, STB)\r\nMBD = (CQK, NHH)\r\nTPX = (TDJ, SKG)\r\nHRC = (LBB, JLR)\r\nQHN = (JHT, THC)\r\nSPM = (DDG, MBK)\r\nMFG = (JBD, GSM)\r\nMHR = (PTN, HVB)\r\nRLF = (GMG, TDQ)\r\nXBQ = (KKN, QTN)\r\nGLB = (DHS, SXC)\r\nPRV = (PGC, NSK)\r\nSJD = (BXQ, GHF)\r\nTHC = (XHM, NRK)\r\nGBL = (GGR, HTK)\r\nMDK = (JXX, DBD)\r\nNJT = (QCN, SKL)\r\nLLG = (KBL, LXK)\r\nRVS = (DDB, QRV)\r\nLHR = (LPL, TGJ)\r\nTBD = (NNB, CQH)\r\nDSN = (DFF, XPV)\r\nQQN = (HRV, PTT)\r\nXPP = (GSJ, RDT)\r\nCBJ = (JQL, RBX)\r\nRBX = (CNV, NKQ)\r\nDDG = (NBS, KTV)\r\nXNN = (TMC, GCG)\r\nDSX = (CGR, SGM)\r\nDFB = (RCJ, KJK)\r\nXTG = (RFG, XSD)\r\nPKQ = (DBD, JXX)\r\nXPD = (GBL, VVR)\r\nFFC = (JLR, LBB)\r\nGMG = (KFH, PTP)\r\nQHJ = (SHM, FKM)\r\nMXD = (XGB, LTX)\r\nSGM = (FTS, GXX)\r\nLTX = (RMT, HGF)\r\nRNQ = (SPL, DKH)\r\nNHF = (VXC, HRS)\r\nKFR = (JXR, PFV)\r\nNRP = (XNN, MTB)\r\nVDR = (LDL, JCP)\r\nFSS = (KXJ, GKL)\r\nQVS = (MKN, BLH)\r\nSNN = (SBM, PNH)\r\nVXB = (LLG, BHP)\r\nBPK = (QVS, PPV)\r\nSMV = (TGJ, LPL)\r\nCXF = (XKV, PVR)\r\nPGC = (NBJ, KCK)\r\nVLG = (DDG, MBK)\r\nFKL = (HFC, XPP)\r\nKFC = (XNM, CNR)\r\nFCC = (BRK, GLT)\r\nHQC = (JKV, JHQ)\r\nQQV = (CPG, HQD)\r\nVVG = (XGJ, XGJ)\r\nSVK = (HVH, HNJ)\r\nXQT = (LQX, HNT)\r\nJDB = (PXM, THR)\r\nJHR = (XRF, DHN)\r\nHRS = (TFJ, PQH)\r\nSVQ = (XHX, QNG)\r\nKGN = (FCV, SBH)\r\nGJX = (MFG, LMS)\r\nNBJ = (GVB, RMS)\r\nVQJ = (JPB, PDF)\r\nTKX = (JMT, LGM)\r\nFLL = (GTX, HKP)\r\nMFT = (FKM, SHM)\r\nJCP = (SSP, VMD)\r\nLPC = (KCD, JDB)\r\nXHR = (XPP, HFC)\r\nFKM = (DLL, XBQ)\r\nMGF = (NFX, MQS)\r\nJXJ = (MMP, CBT)\r\nDFP = (TGM, RHV)\r\nSSM = (NTC, TMT)\r\nDLX = (PXF, SBG)\r\nNNB = (TNT, MMF)\r\nQNG = (RHP, QBT)\r\nFLR = (CJK, QRL)\r\nRCP = (KKG, NTD)\r\nGJV = (SLG, DGN)\r\nFDN = (TBR, QDT)\r\nJTG = (RFT, PRC)\r\nLGM = (DLX, FPT)\r\nQDT = (CXV, SGD)\r\nHKP = (BLB, PCL)\r\nGXB = (MNH, GXT)\r\nQDS = (LTF, FDX)\r\nLMJ = (GJV, HVV)\r\nTDQ = (PTP, KFH)\r\nSGD = (HTT, PNR)\r\nXPV = (BPM, CPH)\r\nPTP = (MKL, KSP)\r\nDKG = (DKK, KNQ)\r\nQCN = (XTD, GQM)\r\nLSV = (GDK, VVD)\r\nMLG = (RLS, RKG)\r\nGMX = (FKL, XHR)\r\nQSN = (PNH, SBM)\r\nCHQ = (KSB, CXF)\r\nRHN = (LTX, XGB)\r\nLVX = (JSF, MLT)\r\nXHM = (FLR, QVK)\r\nNCJ = (CPG, HQD)\r\nMQV = (HBD, LDK)\r\nVVD = (QBV, FKF)\r\nQCD = (GMG, TDQ)\r\nGTH = (DLJ, DQF)\r\nKFH = (KSP, MKL)\r\nNFC = (PKQ, MDK)\r\nNCD = (FNB, LLT)\r\nMKG = (HNS, DDK)\r\nBTV = (KBS, HKH)\r\nQGL = (QTF, CVS)\r\nDDB = (DVF, HXV)\r\nPXF = (CVH, LMJ)\r\nNFV = (XMN, BQR)\r\nDGN = (SNJ, PTL)\r\nHHL = (PHC, QQJ)\r\nXPR = (XGJ, LVQ)\r\nPCQ = (BRD, SFT)\r\nMMT = (RDS, SRS)\r\nDMR = (GJM, BQS)\r\nQPL = (XNQ, CMN)\r\nPDF = (JBH, CTX)\r\nCVR = (STX, MBQ)\r\nLPL = (SFL, PHQ)\r\nFXX = (PNX, PQL)\r\nKLS = (NHG, CHF)\r\nNHX = (TMN, JLJ)\r\nNND = (QHN, XBR)\r\nJTT = (QNG, XHX)\r\nLML = (FDX, LTF)\r\nPCS = (LKV, LXX)\r\nSRV = (KCD, JDB)\r\nNSK = (NBJ, KCK)\r\nMRF = (NKP, JKG)\r\nVPX = (NSN, SMB)\r\nGFT = (FPL, MSB)\r\nDFM = (XKQ, PPQ)\r\nPPQ = (PCS, BSH)\r\nJJC = (JHR, RQG)\r\nJBH = (BDV, QHL)\r\nKNQ = (KNP, MRL)\r\nTBS = (NTD, KKG)\r\nJXL = (RQG, JHR)\r\nGKL = (MJC, QBM)\r\nBQR = (LKQ, CJV)\r\nDGP = (VNT, JRB)\r\nDKR = (VBJ, GVF)\r\nJXN = (BXD, XLT)\r\nTVG = (HGR, GMX)\r\nXSD = (TLM, KPH)\r\nRMT = (GXB, DPT)\r\nFRL = (VVD, GDK)\r\nPNX = (NCD, KHN)\r\nVGK = (CNR, XNM)\r\nMQB = (KSF, LJS)\r\nKDC = (MSB, FPL)\r\nGCD = (CXS, PCC)\r\nXML = (VNT, JRB)\r\nTBL = (GCV, HDH)\r\nBRV = (DKK, KNQ)\r\nJKS = (XXB, ZZZ)\r\nTMC = (MDQ, QJF)\r\nTNT = (NQJ, SSM)\r\nFLF = (XSD, RFG)\r\nJRB = (FDF, HQC)\r\nPTL = (DBQ, MVG)\r\nBGQ = (KFR, HLB)\r\nXTD = (VRS, BRS)\r\nQXX = (SJD, CSH)\r\nFRX = (BQS, GJM)\r\nPQL = (NCD, KHN)\r\nLKV = (PNK, DKR)\r\nHQS = (VVG, XPR)\r\nVPQ = (NTL, VMQ)\r\nTHR = (CBV, CVR)\r\nFST = (BQR, XMN)\r\nDMD = (CVS, QTF)\r\nHXV = (RCP, TBS)\r\nSTM = (RFX, BFR)\r\nJTR = (JTL, JXN)\r\nFLG = (PFQ, CBJ)\r\nCKM = (KFB, HTP)\r\nNCT = (KJK, RCJ)\r\nDKH = (STB, TTB)\r\nQGA = (CGR, SGM)\r\nXNQ = (HJM, MLG)\r\nRGF = (LFN, FGC)\r\nQBV = (VPJ, RMN)\r\nQKJ = (KFC, VGK)\r\nCSB = (FDL, FDL)\r\nHFK = (DHS, SXC)\r\nSVP = (NPJ, BTL)\r\nGGR = (XTG, FLF)\r\nXKV = (NDH, JXJ)\r\nBMR = (FRX, DMR)\r\nVVQ = (BFN, TVK)\r\nHJM = (RKG, RLS)\r\nRLK = (PDF, JPB)\r\nDCX = (HNQ, BRZ)\r\nTBG = (RTL, SML)\r\nRMS = (FRL, LSV)\r\nFCV = (STM, HTC)\r\nSPR = (TBL, JGG)\r\nBHP = (LXK, KBL)\r\nNPJ = (XLV, PQR)\r\nNKF = (TBD, DKP)\r\nPDK = (JTK, JTK)\r\nPFQ = (RBX, JQL)\r\nLBB = (SVP, HTD)\r\nGTX = (BLB, PCL)\r\nSBH = (HTC, STM)\r\nBFR = (RJN, BTN)\r\nTCR = (TBL, JGG)\r\nMQS = (PXX, PLG)\r\nFRG = (XXB, XXB)\r\nSTX = (XQL, HGM)\r\nHNJ = (HBN, SVN)\r\nSSL = (RDL, NST)\r\nHJS = (QCD, RLF)\r\nKBL = (SSL, MFR)\r\nCXS = (RHD, GQR)\r\nDFD = (NFP, FCC)\r\nVBJ = (HFK, GLB)\r\nDKP = (NNB, CQH)\r\nQSK = (TKX, CQT)\r\nBNV = (JTK, GTH)\r\nNBH = (LVX, GQB)\r\nQBM = (VNC, VPK)\r\nDBD = (HHR, RVQ)\r\nDFF = (BPM, CPH)\r\nLQX = (KJT, XXT)\r\nFGC = (QKQ, QSK)\r\nPXM = (CBV, CVR)\r\nJHQ = (CTB, DCX)\r\nNJN = (BGQ, FBP)\r\nTLL = (DDB, QRV)\r\nXSN = (THS, KJQ)\r\nKXJ = (QBM, MJC)\r\nGSC = (TQG, QXX)\r\nQJP = (PQL, PNX)\r\nPHH = (MXD, RHN)\r\nSSC = (NQX, FCH)\r\nXDF = (NLQ, VCR)\r\nBRD = (MQV, FRQ)\r\nAAA = (LRV, HJS)\r\nPTT = (FFC, HRC)\r\nVKF = (BFG, TGQ)\r\nHHA = (FLG, VHN)\r\nCNR = (TQX, VDV)\r\nTGM = (FLL, TNV)\r\nGLT = (DJB, QPL)\r\nMBK = (NBS, KTV)\r\nJPB = (JBH, CTX)\r\nRHP = (SQM, DJP)\r\nCHF = (CLQ, JGQ)\r\nFTL = (PRC, RFT)\r\nSKL = (XTD, GQM)\r\nRBN = (SPM, VLG)\r\nHGF = (GXB, DPT)\r\nBQS = (NSP, BTV)\r\nXHX = (RHP, QBT)\r\nCGR = (GXX, FTS)\r\nBLB = (QJP, FXX)\r\nCRT = (JLJ, TMN)\r\nPLG = (SLC, PDD)\r\nHRV = (FFC, HRC)\r\nMCM = (JXN, JTL)\r\nJGH = (MFG, LMS)\r\nNSP = (KBS, HKH)\r\nMFR = (NST, RDL)\r\nGMF = (TVK, BFN)\r\nSML = (LJL, XFP)\r\nMPL = (RDS, SRS)\r\nQHP = (SPM, VLG)\r\nFCH = (GDC, XRN)\r\nNRQ = (FTL, JTG)\r\nHMB = (CRC, FSS)\r\nKPH = (BNH, SLK)\r\nSRS = (MQB, GCN)\r\nRQM = (TGQ, BFG)\r\nFLN = (CSB, CSB)\r\nBSH = (LKV, LXX)\r\nCRC = (KXJ, GKL)\r\nCJV = (XDF, CHK)\r\nCGJ = (DGP, XML)\r\nSFL = (GJJ, HQS)\r\nPMR = (VPF, GKD)\r\nQTN = (MMT, MPL)\r\nKJQ = (RLK, VQJ)\r\nPBJ = (LFN, FGC)\r\nBTL = (PQR, XLV)\r\nSBX = (KFC, VGK)\r\nQQJ = (PDK, BNV)\r\nBRZ = (GNF, QQN)\r\nJTL = (XLT, BXD)\r\nSKG = (PRV, DBK)\r\nRQG = (DHN, XRF)\r\nDRC = (SFC, CHQ)\r\nTJQ = (NQX, FCH)\r\nPKS = (TMM, PMR)\r\nTRP = (GVD, FBL)\r\nLKQ = (XDF, CHK)\r\nRTL = (XFP, LJL)\r\nPPV = (MKN, BLH)\r\nMTB = (GCG, TMC)\r\nFPT = (PXF, SBG)\r\nLDK = (FDN, PFD)\r\nTND = (PPX, SVK)\r\nVPK = (NHF, JDX)\r\nHTP = (NKF, RPV)\r\nPMS = (SMB, NSN)\r\nGGG = (XKQ, PPQ)\r\nDLL = (KKN, QTN)\r\nJXX = (HHR, RVQ)\r\nKSF = (QPV, GDQ)\r\nXQD = (FGK, BNJ)\r\nRJF = (CSB, KTM)\r\nGCN = (KSF, LJS)\r\nJKP = (LML, QDS)\r\nXFP = (VPX, PMS)\r\nDPT = (GXT, MNH)\r\nDKK = (KNP, MRL)\r\nNKB = (DDK, HNS)\r\nCJK = (GSC, GBQ)\r\nNLM = (LDL, JCP)\r\nVMD = (DFD, XFM)\r\nNBX = (XJC, CGJ)\r\nPRS = (NLM, VDR)\r\nRMQ = (FRG, FRG)\r\nXNM = (TQX, VDV)\r\nLJC = (VDR, NLM)\r\nPHQ = (GJJ, HQS)\r\nKXN = (KHB, HHL)\r\nBXD = (CKM, XVL)\r\nKFB = (NKF, RPV)\r\nNFS = (PRL, RFL)\r\nRJN = (SFV, RRG)\r\nGQM = (VRS, BRS)\r\nKQH = (VBC, BSJ)\r\nDNR = (BMR, LJQ)\r\nHHR = (LPC, SRV)\r\nDLJ = (MHG, MHG)\r\nSMB = (RFJ, NJT)\r\nRHV = (FLL, TNV)\r\nNTD = (HBX, GVS)\r\nVNT = (FDF, HQC)\r\nPRC = (GMF, VVQ)\r\nFBP = (HLB, KFR)\r\nKTM = (FDL, LRZ)\r\nTQP = (QGL, DMD)\r\nSBM = (QPG, KXN)\r\nQVK = (CJK, QRL)\r\nXRF = (RGF, PBJ)\r\nNDH = (CBT, MMP)\r\nGVL = (RTL, SML)\r\nLRZ = (VHN, FLG)\r\nCQH = (MMF, TNT)\r\nSLK = (TJQ, SSC)\r\nQBT = (SQM, DJP)\r\nFNF = (LLG, BHP)\r\nSTB = (KMS, NRP)\r\nHVV = (SLG, DGN)\r\nRFX = (BTN, RJN)\r\nMKL = (GVM, LVP)\r\nVDV = (BPK, CFB)\r\nCBT = (GJX, JGH)\r\nPPX = (HVH, HNJ)\r\nNQJ = (TMT, NTC)\r\nMJH = (MHP, XQT)\r\nLTA = (KLS, BFV)\r\nCSH = (BXQ, GHF)\r\nHTK = (XTG, FLF)\r\nVNC = (JDX, NHF)\r\nBFG = (MRC, NKK)\r\nKKG = (GVS, HBX)\r\nPNK = (GVF, VBJ)\r\nXXB = (LRV, HJS)\r\nDVF = (TBS, RCP)\r\nPNR = (NCJ, QQV)\r\nQKQ = (CQT, TKX)\r\nTTR = (SPL, DKH)\r\nBTN = (RRG, SFV)\r\nVLM = (PHH, SFH)\r\nTQG = (SJD, CSH)\r\nMHP = (LQX, HNT)\r\nNQX = (GDC, XRN)\r\nTQX = (BPK, CFB)\r\nTVB = (LHR, SMV)\r\nMBQ = (XQL, HGM)\r\nHXJ = (MQS, NFX)\r\nDHN = (PBJ, RGF)\r\nBFN = (MKG, NKB)\r\nPVR = (JXJ, NDH)\r\nQRL = (GBQ, GSC)\r\nGJM = (NSP, BTV)\r\nKQV = (NHH, CQK)\r\nKNP = (TKS, PKS)\r\nPDD = (FND, JKP)\r\nGXT = (VKF, RQM)\r\nXDC = (FTL, JTG)\r\nMMF = (SSM, NQJ)\r\nBFV = (CHF, NHG)\r\nDHS = (PHX, PHX)\r\nVXC = (PQH, TFJ)\r\nXLV = (TLL, RVS)\r\nPXX = (SLC, PDD)\r\nGVD = (DRC, DRC)\r\nTHS = (VQJ, RLK)\r\nDBK = (PGC, NSK)\r\nKHB = (PHC, QQJ)\r\nTKS = (PMR, TMM)\r\nSVR = (NJN, TFP)\r\nHNQ = (QQN, GNF)\r\nMKN = (GGG, DFM)\r\nKRP = (NFM, NFC)\r\nSHM = (XBQ, DLL)\r\nNTL = (NCT, DFB)\r\nNRK = (QVK, FLR)\r\nHXL = (DSX, DSX)\r\nKSB = (XKV, PVR)\r\nNKK = (BKF, QMJ)\r\nMHG = (KLS, BFV)\r\nPNP = (XBR, QHN)\r\nCLQ = (TPX, NMV)\r\nRSG = (XDC, NRQ)\r\nBPM = (PCQ, QKX)\r\nPHC = (PDK, BNV)\r\nTNR = (KJV, QGC)\r\nXQL = (VPV, SVR)\r\nMHV = (QTS, RSG)\r\nXBR = (THC, JHT)\r\nBDX = (PHH, SFH)\r\nTBR = (CXV, SGD)\r\nRVQ = (SRV, LPC)\r\nNFM = (PKQ, MDK)\r\nFBL = (DRC, QSZ)\r\nTLM = (BNH, SLK)\r\nNHH = (SKS, GPP)\r\nFKF = (RMN, VPJ)\r\nXVL = (HTP, KFB)\r\nNHG = (CLQ, JGQ)\r\nFGK = (NBH, KBX)\r\nVMQ = (DFB, NCT)\r\nLXX = (DKR, PNK)\r\nSMJ = (QGB, NFS)\r\nLVP = (KDC, GFT)\r\nQGB = (PRL, RFL)\r\nBRX = (BNJ, FGK)\r\nBDV = (MRF, RXX)\r\nSJM = (BMR, LJQ)\r\nGBQ = (TQG, QXX)\r\nJXR = (XJT, CVX)\r\nTMN = (XSN, PQM)\r\nCQT = (LGM, JMT)\r\nCPG = (QHP, RBN)\r\nBKZ = (BFV, KLS)\r\nVVR = (HTK, GGR)\r\nXFM = (NFP, FCC)\r\nCVH = (GJV, HVV)\r\nVPS = (XQT, MHP)\r\nMDJ = (QHJ, MFT)\r\nSNF = (QTS, RSG)\r\nNKQ = (HMB, JVX)\r\nPRL = (FNF, VXB)\r\nCMN = (MLG, HJM)\r\nJQL = (NKQ, CNV)\r\nQSZ = (CHQ, SFC)\r\nHLR = (MHV, SNF)\r\nRDL = (TBG, GVL)\r\nGVM = (KDC, GFT)\r\nKTV = (CKK, VBK)\r\nSLC = (JKP, FND)\r\nQHL = (MRF, RXX)\r\nKKN = (MPL, MMT)\r\nTNV = (HKP, GTX)\r\nQMJ = (TVG, JCF)\r\nBSJ = (NFV, FST)\r\nBNJ = (NBH, KBX)\r\nXXQ = (GCD, CMQ)\r\nTGQ = (NKK, MRC)\r\nSVH = (NFC, NFM)\r\nLQB = (FRG, JKS)\r\nGNF = (HRV, PTT)\r\nPFV = (CVX, XJT)\r\nJTK = (DLJ, DLJ)\r\nKSP = (LVP, GVM)\r\nPFD = (TBR, QDT)\r\nMLT = (KSQ, KKJ)\r\nGVF = (HFK, GLB)\r\nJLS = (PPX, SVK)\r\nTBK = (CMQ, GCD)\r\nLJB = (QHJ, MFT)\r\nKSQ = (PST, TQP)\r\nSXC = (PHX, TRP)\r\nTTB = (NRP, KMS)\r\nVBX = (MHV, SNF)\r\nCXV = (PNR, HTT)\r\nXCT = (NFS, QGB)\r\nJBD = (KRP, SVH)\r\nJDX = (HRS, VXC)\r\nBNH = (TJQ, SSC)\r\nHQD = (RBN, QHP)\r\nRXX = (NKP, JKG)\r\nNTC = (NND, PNP)\r\nQTF = (TVQ, MHR)\r\nJND = (FCV, SBH)\r\nRDS = (MQB, GCN)\r\nFDL = (FLG, VHN)\r\nTGJ = (SFL, PHQ)\r\nKBX = (GQB, LVX)\r\nGQR = (TMD, KQH)\r\nLMS = (JBD, GSM)\r\nVPJ = (SMJ, XCT)\r\nLVQ = (HXL, VNK)\r\nGDK = (QBV, FKF)\r\nKCD = (PXM, THR)\r\nJGG = (GCV, HDH)\r\nNFP = (BRK, GLT)\r\nSFV = (TBK, XXQ)\r\nKJK = (QKN, XPD)\r\nCVX = (SBX, QKJ)\r\nGCG = (QJF, MDQ)\r\nFNB = (VFV, VPQ)\r\nCBV = (STX, MBQ)\r\nPNH = (QPG, KXN)\r\nHFC = (GSJ, RDT)\r\nGHF = (FLN, RJF)\r\nCKK = (BRV, DKG)\r\nLFN = (QKQ, QSK)\r\nMNH = (VKF, RQM)\r\nMMP = (GJX, JGH)\r\nHVB = (SSG, TNR)\r\nTMD = (BSJ, VBC)\r\nQTS = (NRQ, XDC)\r\nTVQ = (PTN, HVB)\r\nHTT = (QQV, NCJ)\r\nPQM = (KJQ, THS)\r\nXJT = (QKJ, SBX)\r\nPST = (QGL, DMD)\r\nXXT = (MBD, KQV)\r\nPCL = (QJP, FXX)\r\nMJC = (VPK, VNC)\r\nQPV = (JLS, TND)\r\nJLJ = (PQM, XSN)\r\nBKF = (TVG, JCF)\r\nSFT = (FRQ, MQV)\r\nXGJ = (HXL, HXL)\r\nJSF = (KKJ, KSQ)\r\nRMN = (XCT, SMJ)\r\nRPV = (TBD, DKP)\r\nXLT = (CKM, XVL)\r\nDJB = (CMN, XNQ)\r\nKCK = (GVB, RMS)\r\nLLT = (VFV, VPQ)\r\nCVS = (MHR, TVQ)\r\nNBS = (VBK, CKK)\r\nLJQ = (DMR, FRX)\r\nHKS = (TGM, RHV)\r\nHTC = (BFR, RFX)\r\nLDL = (VMD, SSP)\r\nQRV = (HXV, DVF)\r\nNST = (TBG, GVL)\r\nGQB = (JSF, MLT)\r\nKJT = (MBD, KQV)\r\nGSJ = (SVQ, JTT)\r\nFDX = (TVB, GXP)\r\nSSP = (XFM, DFD)\r\nFRQ = (LDK, HBD)\r\nJLR = (HTD, SVP)\r\nHNS = (SPR, TCR)\r\nMCZ = (SGM, CGR)\r\nGCV = (VPS, MJH)\r\nMDQ = (JJC, JXL)\r\nRKG = (NHX, CRT)\r\nTMT = (NND, PNP)\r\nSFC = (KSB, CXF)\r\nCQK = (SKS, GPP)\r\nFND = (LML, QDS)\r\nHVH = (HBN, SVN)\r\nCNV = (HMB, JVX)\r\nCMQ = (CXS, PCC)\r\nNLQ = (JTR, MCM)\r\nGDC = (RMQ, RMQ)\r\nPHX = (GVD, GVD)\r\nNKP = (HXJ, MGF)\r\nRRG = (XXQ, TBK)\r\nTFP = (BGQ, FBP)\r\nGXX = (LJB, MDJ)";
        internal static Dictionary<string, Dictionary<char, string>> locations;
        internal static List<string> currentLocations = new List<string>();

        internal static void PopulateLocations()
        {
            string[] nodeList = nodes.Split("\r\n");
            locations = new Dictionary<string, Dictionary<char, string>>();

            foreach (string node in nodeList) 
            {
                if (node[2] == 'A')
                {
                    currentLocations.Add(node.Substring(0, 3));
                }
                locations[node.Substring(0, 3)] = new Dictionary<char, string>();
                locations[node.Substring(0, 3)]['L'] = node.Substring(7, 3);
                locations[node.Substring(0, 3)]['R'] = node.Substring(12, 3);

                Console.WriteLine("{0} <- {1} -> {2}", node.Substring(0, 3), node.Substring(7, 3), node.Substring(12, 3));
            }
        }

        internal static bool AllLocationsEndWithZ()
        {
            foreach (string node in currentLocations) 
            {
                if (node[2] != 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        internal static long GetStepsToLeaveDesert()
        {
            long accum = 0;
            string currrentNode = "AAA";
            int i = 0;

            while(!currrentNode.Equals("ZZZ"))
            {
                currrentNode = locations[currrentNode][pathSequence[i]];
                accum++;
                i = (i + 1) % pathSequence.Length;
            }

            return accum;
        }

        internal static long GetStepsToLeaveDesertPart2()
        {
            long accum = 0;
            int i = 0;

            while (!AllLocationsEndWithZ())
            {
                for(int j = 0; j < currentLocations.Count; j++) 
                {
                    currentLocations[j] = locations[currentLocations[j]][pathSequence[i]];
                }

                accum++;
                i = (i + 1) % pathSequence.Length;
            }

            return accum;
        }

        internal static void Part1()
        {
            PopulateLocations();

            Console.WriteLine(GetStepsToLeaveDesert());
        }

        internal static void Part2() 
        {
            PopulateLocations();

            Console.WriteLine(GetStepsToLeaveDesertPart2());
        }
        
        public static void Main()
        {
            Part1();
        }
    }
}