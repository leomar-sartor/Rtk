g++ -c -DBUILD_MY_DLL shared_lib_rtk.cpp
g++ -shared -o shared_lib_rtk.dll shared_lib_rtk.o -Wl,--out-implib,libshared_lib_rtk.a