import pygame
import sys

class TileMap:
    def __init__(self,tile_size=64):
        self.tile_size = tile_size
        self.tilemap = {}
        self.offgrid_tiles = []
    