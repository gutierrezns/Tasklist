pre requirements:
- VisualStudio 2022 with ASP.NET and web develpment and .NET 5.0 Runtime
- Nodejs
- SQL Server running on local environment with a usr: 'TaskApplication' psw: 'password' with 'sysadmin' privilegies  

Using CMD standing on .\BE-Netcore you can 'dotnet build' and 'dotnet run' the backend
Swagger installed so you can access to https://localhost:5001/swagger/index.html and manual test the API

open fe-react forlder with VSCode and from a Terminal: 'npm install --force' and 'npm start'

new tasks should be created everytime the app is starter or refreshed
completed tasks will be filtered at Frontend but still stored on DB with isCompleted flag in 'true'
