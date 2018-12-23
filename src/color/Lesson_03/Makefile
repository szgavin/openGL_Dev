CXXFLAGS = -I/home/gavin/git_hub_sourcecode/my_git/3d_game_componet_dev/src/color/Lesson_03
objects = -rdynamic -lGLU -lGL /usr/local/lib/libglfw3.a /usr/local/lib/libGLEW.a -lGLU -lGL -lGLU -lXrandr -lXext -lX11 -lrt -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -lGL
multiple_light:multiple_light.o shader.o
	g++ -o multiple_light multiple_light.o shader.o $(objects)

multiple_light.o:multiple_light.cpp
	g++ -c $(CXXFLAGS) multiple_light.cpp
shader.o:shader.cpp shader.hpp
	g++ -c shader.cpp
.PHONY:clean
clean:
	rm multiple_light  multiple_light.o shader.o

