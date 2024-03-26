from deep_translator import GoogleTranslator

translator = GoogleTranslator(source='auto', target='auto')

while True:
    text = input("Введите текст ('выход/exit' для завершения): ")
    if text.lower() == "выход":
        break
    if text.lower() == "exit":
        break

    src_lang = input("Введите исходный язык (en/ru): ").lower()
    if src_lang not in ["en", "ru", ]:
        print("Некорректный язык. Попробуйте снова.")
        continue

    dest_lang = "ru" if src_lang == "en" else "en"

    try:
        translator = GoogleTranslator(source=src_lang, target=dest_lang)
        translation = translator.translate(text)
        print(f"{dest_lang}: {translation}")
    except Exception as e:
        print(f"Ошибка перевода: {e}")