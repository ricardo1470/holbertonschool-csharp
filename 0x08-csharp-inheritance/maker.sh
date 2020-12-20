#!/usr/bin/env bash

if [[ $# -lt 1 ]];
then
    echo "usage: $0 file"
    exit 0
fi
file=$(cat $1)
touch README.md
sleep 2
for name in ${file}; do
    echo "$name"
    dotnet new console -o "./$name/"
    dotnet build "./$name/"
    $(mv ./$name/Program.cs ./$name/"${name}.cs")
    echo -e "\e[0;32mfile ${name} created successfully \e0"
done
