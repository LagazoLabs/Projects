# Import modules
import pygame
import sys

# Import scripts from other files
from scripts._spritesheet_ import SpriteSheet
from scripts._physics_ import PhysicsEntity
from scripts._utils_ import load_image
from scripts._tilemap_ import TileMap
 
class Game:
    def __init__(self):
        # Intialize the game.
        pygame.init()
        
        pygame.display.set_caption("The Day and Life Of a Cat") # Sets the game title.
        self.screen = pygame.display.set_mode((640, 480)) # Sets the window size.
        self.clock = pygame.time.Clock() # Sets the frame per second (fps).
                
        self.image_pos = [260, 384] # Sets the inital position for an image.
        self.y_movement = [False, False] # Manages the keyboard detection for the vertical (y) movement.
        self.x_movement = [False, False] # Manages the keyboard detection for the horizontol (x) movement.
        
        # # Creates the player as a physics entity.
        self.player = PhysicsEntity(self, 'player', (50, 384), (8, 15)) 
        self.cat_run_frame = 0 # Manages which frame will be used.
        self.SPEED = 3 # Manages the speed of the movement.
 
        # Variables for loading in the assets/frames of those assets.
        BLACK = (0, 0, 0) 
        PLAYER_SCALE = 2
        GRASS_SCALE = 1
        TREE_SCALE = 1       
        
        # Load in assets.
        self.assets = {
            # Run animation frames for player.
            'player' : [
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(0, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(1, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(2, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(3, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(4, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(5, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(6, 31, 17, PLAYER_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/character/cat_run_spritesheet.png")).get_frame(7, 31, 17, PLAYER_SCALE, BLACK)
                ],
            # The grass and ground images.
            'grass' : [
                    # Top Layer (Grass) : 0 - 6
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(0, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(1, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(2, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(3, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(4, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(5, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_0.png")).get_frame(6, 32, 32, GRASS_SCALE, BLACK),
                    # Top Layer (Ground) : 7 - 13
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(0, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(1, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(2, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(3, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(4, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(5, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_1.png")).get_frame(6, 32, 32, GRASS_SCALE, BLACK),
                    # Low Layer (Ground) : 14 - 20
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(0, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(1, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(2, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(3, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(4, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(5, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_2.png")).get_frame(6, 32, 32, GRASS_SCALE, BLACK),
                    # Lower Layer (Ground) : 15 - 21
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(0, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(1, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(2, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(3, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(4, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(5, 32, 32, GRASS_SCALE, BLACK),
                    SpriteSheet(load_image("sprites/terrain/Ground and Trees/grass_main_3.png")).get_frame(6, 32, 32, GRASS_SCALE, BLACK),                        
                ],
            # Background images such as mountains or the sky for decoration.
            'background' : [
                # Sky
                load_image("sprites/terrain/Mountains/Background.png"),
                load_image("sprites/terrain/Mountains/Layer 1 anim1.png"),
                load_image("sprites/terrain/Mountains/Layer 2 anim1.png"),
            ],
            # Trees for decoration.
            'tree' : [
                SpriteSheet(load_image("sprites/terrain/Ground and Trees/trees.png")).get_frame(0, 70, 146, TREE_SCALE, BLACK),
                SpriteSheet(load_image("sprites/terrain/Ground and Trees/trees.png")).get_frame(1, 70, 146, TREE_SCALE, BLACK)
            ]
        }
        
    def run(self):
        
        player_frame = 0
        
        while True:
            self.screen.fill((14, 219, 248))
            #self.screen.blit(self.assets['background'][1],(0,0))
            #self.screen.blit(pygame.transform.scale(self.assets['background'][1], (950 * .8, 256 * .8)),(0,480-128))
            if self.cat_run_frame >= 7:
                self.cat_run_frame = 0
            
            # Render the ground.
            current_x = 0    
            for x in range(20):
                self.screen.blit(self.assets['grass'][7],(current_x,416))
                current_x += 32           
            current_x = 0
            for x in range(20):
                self.screen.blit(self.assets['grass'][14],(current_x,448))
                current_x += 32 
                
            # Render the trees
            current_x = 64
            self.screen.blit(self.assets['tree'][0],(0,300))
            for x in range(10):
                self.screen.blit(self.assets['tree'][0],(current_x,300))
                current_x += 64
                
            # Render the grass.
            current_x = 0
            for x in range(20):
                self.screen.blit(self.assets['grass'][0],(current_x,384))
                current_x += 32 
   
            # Update the movement of the player.
            self.player.update(((self.x_movement[1] - self.x_movement[0]) * self.SPEED, 0))
            # Render the player onto the new position with the new frame.
            
            self.player.render(self.screen, self.cat_run_frame)
            
            for event in pygame.event.get():                
                if event.type == pygame.QUIT:
                    pygame.quit()
                    sys.exit()
                # Detects when the movement keys are pressed.
                if event.type == pygame.KEYDOWN:
                    # Vertical (y) movement.
                    if event.key == pygame.K_w:
                        self.y_movement[0] = True
                    if event.key == pygame.K_s:    
                        self.y_movement[1] = True 
                    # Horizontol (x) movement.
                    if event.key == pygame.K_a:
                        self.x_movement[0] = True
                        self.cat_run_frame += 1
                    if event.key == pygame.K_d:    
                        self.x_movement[1] = True
                        self.cat_run_frame += 1
                # Detects when the movement keys are no longer pressed.                                                     
                if event.type == pygame.KEYUP:
                    # Vertical (y) movement.
                    if event.key == pygame.K_w:
                        self.y_movement[0] = False
                    if event.key == pygame.K_s:    
                        self.y_movement[1] = False
                    # Horizontol (x) movement.
                    if event.key == pygame.K_a:
                        self.x_movement[0] = False
                    if event.key == pygame.K_d:    
                        self.x_movement[1] = False
     
            pygame.display.update()  
            self.clock.tick(60)

if __name__ == '__main__':
    platformer = Game()
    platformer.run()