package = "neo-tree-dotnet"
version = "dev-1"
source = {
   url = "git+ssh://git@github.com/mrfolksy/neo-tree-dotnet.git"
}
description = {
   homepage = "*** please enter a project homepage ***",
   license = "*** please specify a license ***"
}
build = {
   type = "builtin",
   modules = {
      ["neo-tree-dotnet.init"] = "lua/neo-tree-dotnet/init.lua"
   }
}
