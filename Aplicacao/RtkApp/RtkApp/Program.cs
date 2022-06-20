using System;
using System.Runtime.InteropServices;

namespace RtkApp
{
    class Program
    {

        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Fonte\\src\\postpos.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int postpos(gtime_t ts, gtime_t te, double ti, double tu, int n, string outfile, string rov, string bas);

        const int MAX = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("===  INICIANDO APLICAÇÃO  ===");

            var ts = new gtime_t();
            ts.time = 12;
            ts.sec = 345;

            var te = new gtime_t();
            te.time = 13;
            te.sec = 346;

            int numero_files = 4;
            string outfile = "C:\\Users\\Cliente\\Desktop\\Sistema\\Files\\Results";
            string rov = "C:\\Users\\Cliente\\Desktop\\Sistema\\Files\\Results";
            string bas = "C:\\Users\\Cliente\\Desktop\\Sistema\\Files\\Results";

            int retorno = postpos(ts, te, 347, 348, numero_files, outfile, rov, bas);

            Console.WriteLine("\n\n Retorno : " + retorno);

            Console.WriteLine("\n=== FINALIZANDO APLICAÇÃO ===");
            Console.ReadKey();
        }

        struct gtime_t
        {
            public long time { get; set; }
            public double sec { get; set; }
        }

        /* processing options type */
        struct prcopt_t
        {
            int mode;           /* positioning mode (PMODE_???) */
            int soltype;        /* solution type (0:forward,1:backward,2:combined) */
            int nf;             /* number of frequencies (1:L1,2:L1+L2,3:L1+L2+L5) */
            int navsys;         /* navigation system */
            double elmin;       /* elevation mask angle (rad) */
            snrmask_t snrmask;  /* SNR mask */
            int sateph;         /* satellite ephemeris/clock (EPHOPT_???) */
            int modear;         /* AR mode (0:off,1:continuous,2:instantaneous,3:fix and hold,4:ppp-ar) */
            int glomodear;      /* GLONASS AR mode (0:off,1:on,2:auto cal,3:ext cal) */
            int bdsmodear;      /* BeiDou AR mode (0:off,1:on) */
            int maxout;         /* obs outage count to reset bias */
            int minlock;        /* min lock count to fix ambiguity */
            int minfix;         /* min fix count to hold ambiguity */
            int ionoopt;        /* ionosphere option (IONOOPT_???) */
            int tropopt;        /* troposphere option (TROPOPT_???) */
            int dynamics;       /* dynamics model (0:none,1:velociy,2:accel) */
            int tidecorr;       /* earth tide correction (0:off,1:solid,2:solid+otl+pole) */
            int niter;          /* number of filter iteration */
            int codesmooth;     /* code smoothing window size (0:none) */
            int intpref;        /* interpolate reference obs (for post mission) */
            int sbascorr;       /* SBAS correction options */
            int sbassatsel;     /* SBAS satellite selection (0:all) */
            int rovpos;         /* rover position for fixed mode */
            int refpos;         /* base position for relative mode */
            /* (0:pos in prcopt,  1:average of single pos, */
            /*  2:read from file, 3:rinex header, 4:rtcm pos) */
            //double eratio[NFREQ]; /* code/phase error ratio */
            //double err[5];      /* measurement error factor */
            /* [0]:reserved */
            /* [1-3]:error factor a/b/c of phase (m) */
            /* [4]:doppler frequency (hz) */
            //double std[3];      /* initial-state std [0]bias,[1]iono [2]trop */
            //double prn[5];      /* process-noise std [0]bias,[1]iono [2]trop [3]acch [4]accv */
            double sclkstab;    /* satellite clock stability (sec/sec) */
            //double thresar[4];  /* AR validation threshold */
            double elmaskar;    /* elevation mask of AR for rising satellite (deg) */
            double elmaskhold;  /* elevation mask to hold ambiguity (deg) */
            double thresslip;   /* slip threshold of geometry-free phase (m) */
            double maxtdiff;    /* max difference of time (sec) */
            double maxinno;     /* reject threshold of innovation (m) */
            double maxgdop;     /* reject threshold of gdop */
            //double baseline[2]; /* baseline length constraint {const,sigma} (m) */
            //double ru[3];       /* rover position for fixed mode {x,y,z} (ecef) (m) */
            //double rb[3];       /* base position for relative mode {x,y,z} (ecef) (m) */
            //char anttype[2][MAXANT]; /* antenna types {rover,base} */
            //double antdel[2][3]; /* antenna delta {{rov_e,rov_n,rov_u},{ref_e,ref_n,ref_u}} */
            //pcv_t pcvr[2];      /* receiver antenna parameters {rov,base} */
            //unsigned char exsats[MAXSAT]; /* excluded satellites (1:excluded,2:included) */
            //char rnxopt[2][256]; /* rinex options {rover,base} */
            //int posopt[6];     /* positioning options */
            int syncsol;       /* solution sync mode (0:off,1:on) */
            //double odisp[2][6*11]; /* ocean tide loading parameters {rov,base} */
            exterr_t exterr;    /* extended receiver error model */
        }

        /* SNR mask type */
        struct snrmask_t
        {
            //int ena[2];         /* enable flag {rover,base} */
            //double mask[NFREQ][9]; /* mask (dBHz) at 5,10,...85 deg */
        }

        /* antenna parameter type */
        struct pcv_t
        {
            int sat;            /* satellite number (0:receiver) */
            //char type[MAXANT];  /* antenna type */
            //char code[MAXANT];  /* serial number or satellite code */
            gtime_t ts, te;      /* valid time start and end */
            //double off[NFREQ][ 3]; /* phase center offset e/n/u or x/y/z (m) */
            // double var[NFREQ][19]; /* phase center variation (m) */
        }

        struct exterr_t
        {
            //int ena[4];         /* model enabled */
            //double cerr[4][NFREQ*2]; /* code errors (m) */
            //double perr[4][NFREQ*2]; /* carrier-phase errors (m) */
            //double gpsglob[NFREQ]; /* gps-glonass h/w bias (m) */
           // double gloicb[NFREQ]; /* glonass interchannel bias (m/fn) */
        }


    }
}
