CXXFLAGS = -I/home/gavin/git_hub_sourcecode/my_git/3d_game_componet_dev/src/color/lesson_01 -I../../../include
objects = -rdynamic -lGLU -lGL /usr/local/lib/libglfw3.a /usr/local/lib/libGLEW.a -lGLU -lGL -lGLU -lXrandr -lXext -lX11 -lrt -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -lGL
color:color.o shader.o
	g++ -o color color.o shader.o $(objects)

color.o:color.cpp
	g++ -c $(CXXFLAGS) color.cpp

shader.o:shader.cpp shader.hpp
	g++ -c shader.cpp
.PHONY:clean
clean:
	rm color color.o shader.o

