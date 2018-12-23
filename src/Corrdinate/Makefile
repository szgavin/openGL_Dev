CXXFLAGS = -I/home/gavin/git_hub_sourcecode/my_git/3d_game_componet_dev/src/camera_h -I../../include/
objects = -rdynamic -lGLU -lGL /usr/local/lib/libglfw3.a /usr/local/lib/libGLEW.a -lGLU -lGL -lGLU -lXrandr -lXext -lX11 -lrt -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -ldl -lrt -lm -lX11 -lpthread -lXrandr -lXinerama -lXi -lXxf86vm -lXcursor -lGL
mouse_move:muilt_3d_graphic_object_render.o shader.o
	g++ -o mouse_move muilt_3d_graphic_object_render.o shader.o $(objects)

muilt_3d_graphic_object_render.o:muilt_3d_graphic_object_render.cpp
	g++ -c $(CXXFLAGS) muilt_3d_graphic_object_render.cpp

shader.o:shader.cpp shader.hpp
	g++ -c shader.cpp
.PHONY:clean
clean:
	rm *.o mouse_move

