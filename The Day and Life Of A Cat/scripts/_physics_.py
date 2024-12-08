import pygame
import sys

from scripts._spritesheet_ import SpriteSheet
from scripts._utils_ import load_image

class PhysicsEntity:
    def __init__(self, game, entity_type, position, size):
        self.game = game
        self.entity_type = entity_type
        self.position = list(position)
        self.size = size
        self.velocity = [0, 0]  
        #self.acceleration = [0]
        
    def update(self, movement=(0, 0)):
        # Creates a vector to represent how much the entity should be moved.
        frame_movement = (movement[0] + self.velocity[0], movement[1] + self.velocity[1])
        self.position[0] += frame_movement[0] # Updates x (horizontol) position
        self.position[1] += frame_movement[1] # Updates y (vertical) position
    
    def render(self, surface, frame):
        surface.blit(self.game.assets['player'][frame], self.position)