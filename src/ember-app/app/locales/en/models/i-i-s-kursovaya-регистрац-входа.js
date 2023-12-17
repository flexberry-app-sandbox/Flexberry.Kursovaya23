export default {
  projections: {
    РегистрацВходаE: {
      дата: {
        __caption__: 'Дата'
      },
      комната: {
        __caption__: 'Комната',
        номерКомнаты: {
          __caption__: 'Комната'
        }
      },
      входГостя: {
        __caption__: 'Вход гостя',
        гость: {
          __caption__: 'Гость',
          фИО: {
            __caption__: 'Гость'
          },
          карта: {
            __caption__: '',
            кодКарты: {
              __caption__: 'Номер карты'
            }
          }
        }
      },
      входСотрудника: {
        __caption__: 'Вход сотрудника',
        сотрудник: {
          __caption__: 'Сотрудник',
          фИО: {
            __caption__: 'Сотрудник'
          },
          должности: {
            __caption__: '',
            должность: {
              __caption__: 'Должность'
            }
          },
          карта: {
            __caption__: '',
            кодКарты: {
              __caption__: 'Номер карты'
            }
          }
        }
      }
    },
    РегистрацВходаL: {
      дата: {
        __caption__: 'Дата'
      },
      комната: {
        __caption__: 'Комната',
        номерКомнаты: {
          __caption__: 'Комната'
        }
      }
    }
  },
  validations: {
    дата: {
      __caption__: 'Дата'
    },
    комната: {
      __caption__: 'Комната'
    },
    входСотрудника: {
      __caption__: 'Вход сотрудника'
    },
    входГостя: {
      __caption__: 'Вход гостя'
    }
  }
};
