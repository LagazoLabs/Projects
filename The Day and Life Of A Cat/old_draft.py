"""Disclaimer: Rough Draft"""

# Import packages/libraries.
import pyglet as pg
from pyglet import shapes
from pyglet.window import key
from pyglet import gl
from pyglet import image
import time

# Include other files in this project

# Variables
TITLE = "The Life Of A Cat"
WIDTH = 800
HEIGHT = 600
SPEED = 5
DIRECTIONS = {
    'left' : False,
    'right' : False,
    #'up' : False,
    #'down' : False
    'jump' : False
}
CURRENT_FRAME = 0

# Apperance settings for the window.
keys = key.KeyStateHandler()
window = pg.window.Window(width=WIDTH,height=HEIGHT,caption=TITLE)
window.push_handlers(keys)

music_player = pg.media.Player()
sound = pg.media.load('sound/MaxwellTheme.mp3')

# Drawing objects for the background.
background = shapes.Rectangle(x=0,y=0,width=WIDTH,height=HEIGHT,color=(255,127,182))
ground = shapes.Rectangle(x=0,y=0,width=WIDTH,height=HEIGHT/5,color=(127,255,197))
health_bar = shapes.Rectangle(x=25,y=HEIGHT-50,width=90,height=20,color=(76,255,0))
health_depleted = shapes.Rectangle(x=25,y=HEIGHT-50,width=100,height=20,color=(255,0,0))

# Loads the sprite sheet.
cat_spritesheet = pg.image.load('sprites/cat_sprite_sheet.png')
# Uses ImageGrid to conver the spritesheet into a grid format.
cat_spritesheet_grid = pg.image.ImageGrid(cat_spritesheet, rows=10, columns=8)
# Extracts a position from the grided spritesheet usign a row and column index.
cat_sprite_coordinate = cat_spritesheet_grid[5 * 8 + 0] # row * num_columns + column
# Creates pre-sets so I can later scale the sprite up.
texture = cat_sprite_coordinate.get_texture()
texture.min_filter = gl.GL_NEAREST
texture.mag_filter = gl.GL_NEAREST
# Creates the cat sprite.
cat_sprite = pg.sprite.Sprite(cat_sprite_coordinate,y=HEIGHT/5)
# Scales the sprite up.
cat_sprite.scale = 2

@window.event
def on_draw() -> None:
    # Draws the background.
    window.clear()
    background.draw()
    ground.draw()
    # Draws the cat sprite.
    
    #health_depleted.draw()
    #health_bar.draw()
    cat_sprite.draw()

@window.event
def on_key_press(symbol: int, modifiers: int) -> None:
    #if symbol == key.W or symbol == key.UP:
    #    DIRECTIONS['up'] = True
    if symbol == key.A or symbol == key.LEFT:
        DIRECTIONS['left'] = True
    #if symbol == key.S or symbol == key.DOWN:
    #    DIRECTIONS['down'] = True
    if symbol == key.D or symbol == key.RIGHT:
        DIRECTIONS['right'] = True
    if symbol == key.SPACE:
        DIRECTIONS['jump'] = True
        
@window.event
def on_key_release(symbol: int, modifiers: int) -> None:
    
    cat_sprite.image = cat_spritesheet_grid[7 * 8 + 0]
    #cat_sprite.image = cat_spritesheet_grid[5 * 8 + 0]
    
    #if symbol == key.W or symbol == key.UP:
    #    DIRECTIONS['up'] = False
    if symbol == key.A or symbol == key.LEFT:
        DIRECTIONS['left'] = False
    #if symbol == key.S or symbol == key.DOWN:
    #    DIRECTIONS['down'] = False
    if symbol == key.D or symbol == key.RIGHT:
        DIRECTIONS['right'] = False      
    if symbol == key.SPACE:
        DIRECTIONS['jump'] = False
  
def update(dt: float) -> None:
    
    global CURRENT_FRAME
    
    if CURRENT_FRAME >= 8:
        CURRENT_FRAME = 0
    else:
        CURRENT_FRAME += 1
    
    #if DIRECTIONS['up']:
    #    cat_sprite.y += SPEED
    if DIRECTIONS['left']:
        cat_sprite.scale_x = -1
        cat_sprite.x -= SPEED
        cat_sprite.image = cat_spritesheet_grid[5 * 8 + CURRENT_FRAME]     
        #cat_sprit_coordinate = cat_spritesheet_grid[5 * 8 + CURRENT_FRAME] # row * num_columns + column
        #Texture = cat_sprit_coordinate.get_texture()
        #Texture = Texture.get_transform(flip_x=True)
        #cat_sprite.image = Texture
    #if DIRECTIONS['down']:
    #    cat_sprite.y -= SPEED
    if DIRECTIONS['right']:
        cat_sprite.scale_x = 1
        cat_sprite.x += SPEED
        cat_sprite.image = cat_spritesheet_grid[5 * 8 + CURRENT_FRAME]
        # cat_sprit_coordinate = cat_spritesheet_grid[5 * 8 + CURRENT_FRAME] # row * num_columns + column
        # Texture = cat_sprit_coordinate.get_texture()
        # Texture = Texture.get_transform(flip_x=False)
        # cat_sprite.image = Texture
    if DIRECTIONS['jump']:
        cat_sprite.y += SPEED
        
# keep playing for as long as the app is running (or you tell it to stop):d
music_player.play()   
#music_player.eos_action = pg.media.SourceGroup.loop

pg.clock.schedule_interval(update,1/30)
pg.app.run()