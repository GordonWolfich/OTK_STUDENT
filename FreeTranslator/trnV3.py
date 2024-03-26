from deep_translator import GoogleTranslator

def translate_text(src_lang, dest_lang, text):
    try:
        translator = GoogleTranslator(source=src_lang, target=dest_lang)
        translation = translator.translate(text)
        return translation
    except Exception as e:
        print(f"Ошибка перевода: {e}")
        return None
# Меню выбора языка
def menu(): 
    print("Выберите исходный язык:")
    print("1. Английский")
    print("2. Русский")
    print(f"Назад/Back для возвращения к выбору языка.")
# Добавление и выбор исходного языка(source) (https://pypi.org/project/translators/ - символы языков)
    src_lang_choice = input("\nВведите номер: ") 

    if src_lang_choice == "1":
        src_lang = "en"
    elif src_lang_choice == "2":
        src_lang = "ru"
    else:
        print("Некорректный выбор.")
        return menu()
# Если ты в начале выбрал исходный язык, то перевод(dest_lang) будет автоматически переводится. 
# Можно добавлять свои языки для перевода, но сначала добавьте их в меню выбора языков и в src_lang
    if src_lang_choice == "2": 
        dest_lang = "en" 
    elif src_lang_choice == "1": 
        dest_lang = "ru" 
    else:
        print("Некорректный выбор.")
        return menu()

    return src_lang, dest_lang

while True:
    src_lang, dest_lang = menu()

    while True:
        text = input(f"\nИсходный текст: ") # Ввод исходного текста

        if text.lower() == "назад" or text.lower() == "back": # Это функция возвращает к выбору языка!
            break

        translation = translate_text(src_lang, dest_lang, text) 
        if translation:
            print(f"\nПеревод: {translation}") # Перевод исходного текста