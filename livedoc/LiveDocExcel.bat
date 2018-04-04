rd Documentation /S /Q
md Documentation
cd ..
cd src\
call runTests.bat
cd ..
cd livedoc
.\tools\pickles.exe -df=excel -f="..\src\Chess.Tests" -o=".\Documentation" -trfmt=vstest -sn="Chess" -lr="..\src\Chess.Tests\TestResults\res.xml"