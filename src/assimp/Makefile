INCLUDE_DIRS := ../../include/
CXXFLAGS = -I/home/gavin/git_hub_sourcecode/my_git/3d_game_componet_dev/src/assimp -I../../include/
objects = -rdynamic -lGLU -lGL /usr/local/lib/libglfw3.a /usr/local/lib/libGLEW.a /usr/local/lib/libassimp.a -lGLU -lGL -lGLU -lXrandr -lXext -lX11 -lrt -ldl -lrt -lm -lX11 -lz -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -lGL
model_loading: model_loading.o shader.o
	g++ -o  model_loading  model_loading.o shader.o $(objects)

model_loading.o: model_loading.cpp
	g++ -c $(CXXFLAGS)  model_loading.cpp
shader.o:shader.cpp shader.hpp
	g++ -c shader.cpp
.PHONY:clean
clean:
	rm  model_loading  model_loading.o shader.o

