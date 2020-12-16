#!/usr/bin/env bash

if [[ $# -lt 2 ]];
then
    echo "usage: $0 <directory> <file>"
    exit 0
fi

declare -a filenames=()
i=0

while IFS= read -r line; do
    filenames[i]=$line
    let "i++"
done < $2
i=0
dir=$(cat $1)
for dirname in ${dir}; do
    #create directory
    $(mkdir $dirname/)
    cd ./$dirname/
    #run command dotnet new sln
    dotnet new sln
    $(mkdir ./${filenames[i]}/)
    cd ./${filenames[i]}/
    dotnet new classlib
    $(mv ./Class1.cs ./"${filenames[i]}.cs")
    cd ..
    dotnet sln add ./${filenames[i]}/"${filenames[i]}.csproj"
    $(mkdir ./"${filenames[i]}.Test")
    cd ./"${filenames[i]}.Test"/
    dotnet new nunit
    $(mv ./UnitTest1.cs "${filenames[i]}.Test.cs")
    dotnet add reference ../${filenames[i]}/"${filenames[i]}.csproj"
    cd ..
    dotnet sln add ./"${filenames[i]}.Test"/"${filenames[i]}.Test.csproj"
    let "i++"
    cd ..
done
