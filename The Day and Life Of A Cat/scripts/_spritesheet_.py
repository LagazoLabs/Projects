"""Origianl Code: https://github.com/russs123/pygame_tutorials/tree/main."""
# Helps load in sprite sheets and easily converts them into individual frames.

import pygame
import sys

class SpriteSheet():
	def __init__(self, image):
		self.sheet = image

	def get_frame(self, frame, width, height, scale, colour):
		image = pygame.Surface((width, height)).convert_alpha()
		image.blit(self.sheet, (0, 0), ((frame * width), 0, width, height))
		image = pygame.transform.scale(image, (width * scale, height * scale))
		image.set_colorkey(colour)

		return image