# SignalRDependencyBugSample
Sample project to display a dependency bug in SignalR core rc1

REPRO:
- Copy repo
- Compile solution
- Host server with "dotnet Server.dll" [Executed via powershell in the directory of the binaries]
- Debug the client with VS2017

RESULT:
- Crash on connect
