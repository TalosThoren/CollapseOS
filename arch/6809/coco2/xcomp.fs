( TRS-80 Color Computer 2 )
50 LOAD ( 6809 assembler )
0x8000 CONSTANT PS_ADDR 0x7f00 CONSTANT RS_ADDR
0x0600 CONSTANT HERESTART
RS_ADDR 0xb0 - CONSTANT SYSVARS
SYSVARS 0xa0 + CONSTANT GRID_MEM
0xc000 BIN( !
450 LOAD ( boot.6809 declarations )
200 205 LOADR ( xcomp )
451 459 LOADR ( boot.6809 )
210 231 LOADR ( forth low )
461 463 LOADR ( drivers )
240 241 LOADR ( Grid )
236 239 LOADR ( forth high )
XWRAP" GRID$ "
