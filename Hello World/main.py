select = -1
options = ["English", "Spanish", "Chinese", "Japanese", "Korean", "French"]

for option in options:
    print(f"[{options.index(option)}] {option}")

while (select <= -1) or (select >= 6):
    select = int(input("Select Language To Print 'Hello World' In (ex: 0, 1, 2, 4): "))
    match select:
        case 0:
            print("\nHello World\n")
        case 1:
            print("\n¡Hola Mundo\n!")
        case 2:
            print("\nこんにちは世界！\n")
        case 3:
            print("\n你好世界！\n")
        case 4:
            print("\n안녕 세상!\n")
        case 5:
            print("\nBonjour le monde!\n")