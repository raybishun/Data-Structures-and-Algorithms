def read_maze(file_name):
    """
    Parses a maze text file and retuns as a 2d list
    """
    try:
        with open(file_name) as fh:
            maze = [[char for char in line.strip("\n")] for line in fh]
            num_cols_top_row = len(maze[0])
            for row in maze:
                if len(row) != num_cols_top_row:
                    print("The maze is not rectangular.")
                    raise SystemExit
            return maze
    except OSError:
        print("There is a problem with the file you selected.")
        raise SystemExit

if __name__ == "__main__":
    maze = read_maze("mazes/modest_maze.txt")
    for row in maze:
        print(row)