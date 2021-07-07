\ RC2014 classic with SIO
10 VALUES RS_ADDR 0xff00 PS_ADDR 0xfffa HERESTART 0x8000
         SIOA_CTL 0x80 SIOA_DATA 0x81
         SIOB_CTL 0x82 SIOB_DATA 0x83
         SPI_DATA 4 SPI_CTL 5 SDC_DEVID 1
RS_ADDR 0x80 - VALUE SYSVARS
5 LOAD    ( z80 assembler )
280 LOAD  ( boot.z80.decl )    200 205 LOADR ( xcomp )
281 300 LOADR ( boot.z80 )
210 231 LOADR ( forth low )    325 327 LOADR ( SIO )
312 LOAD  ( SPI relay )        250 258 LOADR ( SD Card )
311 LOAD  ( AT28 )
X' SIOA<? ALIAS (key?) X' SIOA> ALIAS (emit)
X' SIOA<? ALIAS RX<? X' SIOA> ALIAS TX>
: INIT SIOA$ BLK$ ;
236 239 LOADR ( forth high )
XWRAP INIT
