cd .\%1
call nuget pack -sym %1.csproj -Symbols -Properties Configuration=Release
cd ..\
