@del /Q sttp.net\*.cs
swig -c++ -csharp -outdir sttp.net -namespace sttp -dllimport sttp.net.lib.dll -o sttp.net.lib/sttp.net.lib.cpp sttp.i
@pause