dotnet restore HaloLive.Library.sln -NoCache -NonInteractive -ConfigFile Nuget.config
msbuild Booma.Library.sln /p:Configuration=Release