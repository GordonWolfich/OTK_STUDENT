from deep_translator import GoogleTranslator

def translate_text(src_lang, dest_lang, text):
    try:
        translator = GoogleTranslator(source=src_lang, target=dest_lang)
        translation = translator.translate(text)
        return translation
    except Exception as e:
        print(f"Ошибка перевода: {e}")
        return None

def menu():
    print("Выберите исходный язык:")
    print("1. Английский")
    print("2. Русский")
    src_lang_choice = input("Введите номер: ")

    if src_lang_choice == "1":
        src_lang = "en"
    elif src_lang_choice == "2":
        src_lang = "ru"
    else:
        print("Некорректный выбор.")
        return menu()

    print("\nВыберите язык перевода:")
    print("1. Английский")
    print("2. Русский")
    dest_lang_choice = input("Введите номер: ")

    if dest_lang_choice == "1":
        dest_lang = "en"
    elif dest_lang_choice == "2":
        dest_lang = "ru"
    else:
        print("Некорректный выбор.")
        return menu()

    return src_lang, dest_lang

while True:
    src_lang, dest_lang = menu()

    while True:
        text = input("\nВведите текст ('выход/exit' для возвращения в меню): ")

        if text.lower() == "выход" or text.lower() == "exit":
            break

        translation = translate_text(src_lang, dest_lang, text)
        if translation:
            print(f"{dest_lang}: {translation}")