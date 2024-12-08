"""Code that was previously used to load in the spritesheet for the player."""

    # This code was used in: def __init__(self)
        # Load sprite sheet image.
        #cat_run_spritesheet_image = pygame.image.load("sprites/character/cat_run_spritesheet.png").convert_alpha()
        # Create a spritesheet object.
        #cat_run_spritesheet_object = SpriteSheet(cat_run_spritesheet_image)  

"""Code that was previously used to manage how the frames for movement were updated."""

        # This code was used in: def __init__(self)
            # self.cat_running = [
            #  frame_0 := cat_run_spritesheet_object.get_frame(0, 31, 17, SCALE, BLACK),
            #  frame_1 := cat_run_spritesheet_object.get_frame(1, 31, 17, SCALE, BLACK),
            #  frame_2 := cat_run_spritesheet_object.get_frame(2, 31, 17, SCALE, BLACK),
            #  frame_3 := cat_run_spritesheet_object.get_frame(3, 31, 17, SCALE, BLACK),
            #  frame_4 := cat_run_spritesheet_object.get_frame(4, 31, 17, SCALE, BLACK),
            #  frame_5 := cat_run_spritesheet_object.get_frame(6, 31, 17, SCALE, BLACK),
            #  frame_6 := cat_run_spritesheet_object.get_frame(6, 31, 17, SCALE, BLACK),
            #  frame_7 := cat_run_spritesheet_object.get_frame(7, 31, 17, SCALE, BLACK)
            #
            
        # This code was used in : def run(self)
            ## Updates the vertical (x) position if the keys are detected as pressed.
            #self.image_pos[0] += (self.x_movement[1] - self.x_movement[0]) * self.SPEED
            ## Updates the horizontol (y) position if the keys are detected as pressed.
            #self.image_pos[1] += (self.y_movement[1] - self.y_movement[0]) * self.SPEED
            ## Loads the images onto the screen.
            #img_r = pygame.Rect(self.image_pos[0],self.image_pos[1], self.cat_running[0].get_width(), self.cat_running[0].get_height())
            #
            #
            #if img_r.colliderect(self.collision_area):
            #    pygame.draw.rect(self.screen, (0, 100, 255), self.collision_area)
            #else:
            #    pygame.draw.rect(self.screen, (0, 50, 155), self.collision_area)
            #    
            #self.screen.blit(self.cat_running[self.cat_run_frame],self.image_pos)