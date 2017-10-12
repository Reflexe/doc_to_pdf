#!/usr/bin/sh

cd Output/MonoLinux
mono ../../../Test.exe ../../testdoc.doc 
mono ../../../Test.exe ../../testdocx.docx
cd ../MonoWine
wine ../../../Test.exe  ../../testdocx.docx
wine ../../../Test.exe  ../../testdoc.doc
