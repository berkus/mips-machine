In college, my Machine Organization and Architecture professor is teaching the MIPS architecture. Since it's so simple, I'm building a MIPS simulator and assembler as a project.

It will be compatible with the book we're using for learning assembly language (MIPS Assembly Language Programming by Robert L. Britton). The machine will consist of hypothetical components for I/O.

It will probably be sufficient for use as a initial target test platform for the managed operating system I'm writing as an experiment.

**Note for Running C Programs:**

It's best to use an already installed toolchain for C. The target is specified in the App.config file, and the bin directory should be in PATH. The defaults will work (mips-sde-elf).

Here are two places to get a free MIPS bare-metal GCC toolchain:

[developer.mips.com](http://developer.mips.com/tools/compilers/bare-metal-toolchain/) - Pre-built Linux binaries, and build instructions for other platforms

[CodeSourcery CodeBench Lite](https://sourcery.mentor.com/sgpp/lite/mips/portal/release2099) - Pre-built Windows binaries


**News**

**5/7/2012:** I'm ready to present this to my class tomorrow! This project now has basic video functionality accessible from C/ASM. I created a demonstration file, examplevideo.c. [Check it out](http://code.google.com/p/mips-machine/downloads/detail?name=MIPS.Simulator.Presentation.zip&can=2)!

**5/4/2012:** The simulator can now run programs written in C.

**3/12/2012:** Lots of changes so far, see source. I added a current [test build](http://code.google.com/p/mips-machine/downloads/detail?name=MIPS.Simulator.zip&can=2&q=) to the downloads section.

http://mips-machine.googlecode.com/files/MIPSCapture2.PNG

![http://mips-machine.googlecode.com/files/MIPSCapture3.png](http://mips-machine.googlecode.com/files/MIPSCapture3.png)

http://mips-machine.googlecode.com/files/MIPS.PNG

[Initial thread](http://forum.osdev.org/viewtopic.php?f=15&t=24959)

[Donate to my internship](http://bit.ly/2558933), or:

[![](https://www.paypal.com/en_US/i/btn/btn_donate_LG.gif)](http://bit.ly/hl6rer)