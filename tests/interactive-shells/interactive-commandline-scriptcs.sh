#!/bin/bash

# https://github.com/scriptcs/scriptcs/wiki/

rm -fr bin/
mkdir bin/
cp \
    ../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Debug/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll \
    bin/

 tree bin/
