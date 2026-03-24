interface ContactInfo {
  id: number;
  name: string;
  email: string;
  phone: string;
}

class ContactManager {
  private contacts: ContactInfo[] = [];

  addContact(contact: ContactInfo): string {
    const exists: boolean = this.contacts.some((c) => c.id === contact.id);
    if (exists) {
      return "Contact already exists.";
    }

    this.contacts.push(contact);
    return "Contact added";
  }

  viewContacts(): ContactInfo[] {
    return [...this.contacts];
  }

  modifyContact(id: number, updatedContact: Partial<ContactInfo>): string {
    const index: number = this.contacts.findIndex((c) => c.id === id);

    if (index === -1) {
      return "Contact not found";
    }

    this.contacts[index] = {
      ...this.contacts[index],
      ...updatedContact,
    };

    return "Contact updated successfully";
  }

  deleteContact(id: number): string {
    const index: number = this.contacts.findIndex((c) => c.id === id);

    if (index === -1) {
      return "Contact not found.";
    }

    this.contacts.splice(index, 1);
    return "Contact deleted successfully.";
  }
}
