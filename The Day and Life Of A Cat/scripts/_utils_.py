import pygame
import sys

def load_image(path):
    img = pygame.image.load(path).convert()
    img.set_colorkey((0, 0, 0))
    return img