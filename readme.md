http://www.hanselman.com/blog/ExploringTheNewNETDotnetCommandLineInterfaceCLI.aspx

dotnet new - new project
dotnet restore - restore objects
dotnet run - run project

http://blog.stevensanderson.com/2016/05/02/angular2-react-knockout-apps-on-aspnet-core/

https://facebook.github.io/react/docs/getting-started.html

installing yeoman:
Open command prompt.
Install bower : npm install -g bower.
Install grunt-cli : npm install -g grunt-cli.
Install yeoman : npm install -g yo

REF: see auto result from https://www.google.com/search?q=install+yeoman+windows
REF: https://sumankpaul.wordpress.com/2013/11/14/how-to-setup-yeoman-in-windows-from-scratch/

changing the default port for kestrel (when launching)
https://github.com/aspnet/KestrelHttpServer/issues/639

configuring eslint:
http://eslint.org/docs/user-guide/configuring

once visual studio code is installed, you can do:

code .

from a new project (dotnet new) to launch vs code

in new project, need initialization code to launch kestrel and asp.net core
need OWIN interceptor to be able to resolve location of index.html (Spa.Middleware in example project)
need gulp and webpack to be setup to build application
need babel, gulp, react, other packages

npm install graceful-fs
npm install eslint
npm install babel
npm install babel-core
npm install gulp
npm install react
npm install react-dom
npm install es6-promise
npm install eslint-plugin-react
npm install gulp
npm install gulp-cached
npm install gulp-concat-css
npm install gulp-notify
npm install gulp-react
npm install jsx-loader
npm install file-loader
npm install url-loader
npm install webpack
npm install babel-eslint
npm install require-dir
npm install gulp-babel
npm install babel-loader
npm install babel-preset-es2015
npm install babel-preset-react

npm install autoprefixer   <<< ???

setup gulp config to package up react & everything into bundle.js (/src/js/bundle.js -> /wwwroot/src/js/bundle.js)

some gulp stuff from https://github.com/beaupalmquist-hdqc/microservice-client-workshop-2016
