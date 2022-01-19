# Pre req: 
Install .net 6 (.net 6 cli)
Install node.js, npm [optional]
Gitbash
Sourcetree or smartgit
Install Visual Studio Code with below extenstions [some are optional]

    c#
    c# extensions
    nuget gallery
    material icon theme

    Angular Language service
    Angular Snippets by John Papa
    Bracket Pair Colorizer

via nuget
>asset ( generate .net asset for build and debug)
> for Swagger dev interface
SwashBuckle.AspNetCore.MicrosoftExtensions 
Swashbuckle.AspNetCore.SwaggerGen  
Swashbuckle.AspNetCore.SwaggerUI  


# setup proj VSC
Autosave
hide bin or other unwanted folder

# dotnet cmds (gitbash)
$dotnet
$dotnet -h
$dotnet new -h
$dotnet new -l

# new proj setup
$cd [projects location dir]
$mkdir dotnet6projectname
$cd dotnet6projectname
$dotnet new sln
$dotnet new [templatename like web/webapp/webapi/angular/mvc/console] -o APP
$dotnet sln add APP
$dotnet new gitignore

# run dotnet project
-open project is VSC
-open terminal
-cd into APP directory of project
$dotnet run
* click on localhost url in console to see application in browser, if page is not loading ( might need to add path like /weatherforecast for some templates like webapi, others work directly) port can be any available unless you setup/update in APP\Properties\launchSettings.json
$dotnet watch run
- cd into client dir to run angular project with ng serve

# git repo - setup empty repo 
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/xxxx/[reponame].git
git push -u origin main

