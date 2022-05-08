gcc -c rtkcmn.c
gcc -c -x c solution.c
gcc -c convrnx.c
gcc -c rtcm.c
gcc -c sbas.c
gcc -c qzslex.c
gcc -c rtkpos.c

gcc -c preceph.c
gcc -c rinex.c
gcc -c pntpos.c
gcc -c ionex.c
gcc -c geoid.c
gcc -c rcvraw.c
gcc -c rtcm2.c
gcc -c rtcm3.c
gcc -c rtcm3e.c
gcc -c ppp.c
gcc -c ephemeris.c
gcc -c lambda.c
gcc -c ./rcv/novatel.c
gcc -c ./rcv/ublox.c
gcc -c ./rcv/ss2.c
gcc -c ./rcv/crescent.c
gcc -c ./rcv/skytraq.c
gcc -c ./rcv/gw10.c
gcc -c ./rcv/javad.c
gcc -c ./rcv/nvs.c
gcc -c ./rcv/binex.c
gcc -c ./rcv/rt17.c
gcc -c ppp_ar.c
gcc -c -DBUILD_MY_DLL postpos.c 

gcc -shared -o postpos.dll postpos.o rtkcmn.o solution.o convrnx.o rtcm.o sbas.o qzslex.o rtkpos.o preceph.o rinex.o pntpos.o ionex.o geoid.o rcvraw.o rtcm2.o rtcm3.o rtcm3e.o ppp.o ephemeris.o lambda.o novatel.o ublox.o ss2.o crescent.o skytraq.o gw10.o javad.o nvs.o binex.o rt17.o ppp_ar.o -Wl,--out-implib,postpos.a